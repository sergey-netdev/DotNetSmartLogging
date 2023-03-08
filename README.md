# INTRO #

This is a demonstration of a better way of doing logging in modern .NET

### Problem statement ###

Microsoft introduced [ILogger](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger) interface some years ago as part of .NET Core. And it's great, you can instrument your code like this:
```csharp
    logger.LogInformation("Parsing first {batch} rows of total {totalRows}...", batchSize, input.RecordCount);
	
    logger.LogDebug("Error calling the gateway for {userId}. The response was: {response}.", user.Id, ToJson(response));
```

In heavy loaded applications though, you usually have logging level set to WARN or ERR so everything lower is not logged but it's still executing.
There is also a serious problem with `ILogger` - all its logging methods accept `params object?[] args` which means boxing when you pass structs into them.

So, we have two problems here:
 1. Unnecessary calls (which is especially painful when parameters needs to be calculated like in `ToJson(response)` above)
 2. Unnecessary boxing

The usual solution is:
```csharp
    if (logger.IsEnabled(LogLevel.Information))
    {
        logger.LogInformation("Parsing first {batch} rows of total {totalRows}...", batchSize, input.RecordCount);
    }
```

but it's very unhandy as we waste 3 extra lines for every log call. Can we do better?

Yes, and a popular [Serilog](https://serilog.net/) library fixes it by having it's own `ILogger` interface ([source](https://github.com/serilog/serilog/blob/dev/src/Serilog/ILogger.cs)) with log methods declared like this:

```csharp
void Write<T0, T1, T2>(LogEventLevel level, string messageTemplate, T0 propertyValue0)
void Write<T0, T1, T2>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
void Write<T0, T1, T2>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
```

in addition to a usual `params object?[] args` overload.

[NLog](https://nlog-project.org/) library has a similar approach, see the [source](https://github.com/NLog/NLog/blob/dev/src/NLog/Abstractions/ILogger.cs).

Those are superb libraries (and you should use them!) but you can see the problem here - you don't want a dependency on their `ILogger` abstraction, especially in your shared libraries. Remember that versioning hell with [log4net](https://logging.apache.org/log4net/) when it was popular? The diamond problem is no joke. Plus, the overloads in both [Serilog](https://serilog.net/) and [NLog](https://nlog-project.org/) are limited to 3 generic parameters. There is a good reason for this but sometimes you just don't care.

### Problem demo ###

Let's run some tests first (you can do that with `dotnet run -c Release --job short --filter "*PerformanceBoxingTest*"`):
```
|                       Method | LoggerEnabled |       Mean |       Error |    StdDev |   Gen0 | Allocated |
|----------------------------- |-------------- |-----------:|------------:|----------:|-------:|----------:|
|  DefaultLog_1_Params_Structs |         False |  47.588 ns |   3.6540 ns | 0.2003 ns | 0.0053 |      56 B |
|  DefaultLog_2_Params_Structs |         False |  55.085 ns |   8.3701 ns | 0.4588 ns | 0.0083 |      88 B |
| DefaultLog_10_Params_Structs |         False | 120.663 ns |  18.4919 ns | 1.0136 ns | 0.0329 |     344 B |
```

So, not only we burn CPU formatting log messages we also allocate some memory that needs to be collected (which in turn burns CPU).

### Solution ###

Create a set of extension methods for `Microsoft.Extensions.Logging.ILogger` with generic arguments and do the check if a logger is enabled in there:

```csharp
public static partial class SmartLoggerExtensions
{
	public static void LogDebug<T0, T1>(this ILogger logger, string? message, T0 arg0, T1 arg1)
	{
		ArgumentNullException.ThrowIfNull(logger, nameof(logger)); // fail fast

		if (logger.IsEnabled(LogLevel.Debug))
		{
			LoggerExtensions.LogDebug(logger, eventId: 0, exception: null, message, arg0, arg1); // forward to the standard implementation
		}
	}
	
	...
}
```

This works because of the overload resolution - C# compiler chooses a generic overload over a non-generic one.

The standard [LoggerExtensions](https://github.com/dotnet/runtime/blob/main/src/libraries/Microsoft.Extensions.Logging.Abstractions/src/LoggerExtensions.cs) has 4 overloads for every `Log()`, `LogCritical()`, `LogDebug()`, `LogInformation()`, `LogTrace()`, `LogWarning()` methods so if we want similar signatures with 10 generic arguments that is 6 * 4 * 10 = 240 new methods. Test this amount of code is only viable with reflection which is what I've done.

Now, let's see the difference:
```
|                       Method | LoggerEnabled |       Mean |       Error |    StdDev |   Gen0 | Allocated |
|----------------------------- |-------------- |-----------:|------------:|----------:|-------:|----------:|
|    SmartLog_1_Params_Structs |         False |   4.584 ns |   0.6267 ns | 0.0344 ns |      - |         - |
|    SmartLog_2_Params_Structs |         False |   2.585 ns |   0.2237 ns | 0.0123 ns |      - |         - |
|   SmartLog_10_Params_Structs |         False |   2.789 ns |   0.4127 ns | 0.0226 ns |      - |         - |
```

It's x10 faster and we have no allocations! With loggers enabled there will be no difference, of course. We, however, added one extra call. It's static and ultra fast but let's also see if can improve here but applying `[MethodImpl(MethodImplOptions.AggressiveInlining)]`:

```
|                                Method |     Mean |     Error |    StdDev | Allocated |
|-------------------------------------- |---------:|----------:|----------:|----------:|
|             SmartLog_2_Params_Structs | 3.020 ms | 0.0090 ms | 0.0075 ms |       2 B |
|            SmartLog_10_Params_Structs | 2.767 ms | 0.0073 ms | 0.0061 ms |       2 B |
|  SmartLog_2_Params_Structs_NoInlining | 3.015 ms | 0.0043 ms | 0.0036 ms |       2 B |
| SmartLog_10_Params_Structs_NoInlining | 5.286 ms | 0.0166 ms | 0.0138 ms |       5 B |
```

As we can see the JIT compiler does a great job here but in case of a large number of parameters there is a x2 improvement. Not that it's useful or even noticable though so we're good here.

### How to use ###

Simply copy `SmartLoggerExtension*.cs` source files to your shared utility project that has a dependency on `Microsoft.Extensions.Logging.Abstractions` Nuget package. Then add this to your code where you log things:
```
using Microsoft.Extensions.Logging.Smart;
```

That's it. All the new extension methods replicate the existing signatures in the standard `LoggerExtension` class so no changes to your code is needed. You can also utilize the new [global using](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/globalusingdirective) feature of C# 10:
```
global using Microsoft.Extensions.Logging.Smart;
```

