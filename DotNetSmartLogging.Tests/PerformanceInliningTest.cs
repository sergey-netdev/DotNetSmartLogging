namespace DotNetSmartLogging.Tests;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Logging.Smart;

/// <summary>
/// <![CDATA[
/// |                                Method |     Mean |     Error |    StdDev | Allocated |
/// |-------------------------------------- |---------:|----------:|----------:|----------:|
/// |             SmartLog_2_Params_Structs | 3.020 ms | 0.0090 ms | 0.0075 ms |       2 B |
/// |            SmartLog_10_Params_Structs | 2.767 ms | 0.0073 ms | 0.0061 ms |       2 B |
/// |  SmartLog_2_Params_Structs_NoInlining | 3.015 ms | 0.0043 ms | 0.0036 ms |       2 B |
/// | SmartLog_10_Params_Structs_NoInlining | 5.286 ms | 0.0166 ms | 0.0138 ms |       5 B |
/// ]]>
/// </summary>
[MemoryDiagnoser]
public class PerformanceInliningTest
{
    private const int Iterations = 1_000_000;
    private const LogLevel logLevel = LogLevel.Information;
    private readonly Exception ex = new();
    private readonly EventId eventId = new(0, nameof(PerformanceInliningTest));
    private readonly ILogger logger = new NoOutputTestLogger();

    [Benchmark]
    public void SmartLog_2_Params_Structs()
    {
        for (int i = 0; i < Iterations; i++)
        {
            SmartLoggerExtensions.Log(logger, logLevel, eventId, ex, "message {a0} {a1}", 0, 1);
        }
    }

    [Benchmark]
    public void SmartLog_10_Params_Structs()
    {
        for (int i = 0; i < Iterations; i++)
        {
            SmartLoggerExtensions.Log(logger, logLevel, eventId, ex, "message {a0} {a1} {a2} {a3} {a4} {a5} {a6} {a7} {a8} {a9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
        }
    }

    [Benchmark]
    public void SmartLog_2_Params_Structs_NoInlining()
    {
        for (int i = 0; i < Iterations; i++)
        {
            SmartLoggerExtensionsNoInlining.Log(logger, logLevel, eventId, ex, "message {a0} {a1}", 0, 1);
        }
    }

    [Benchmark]
    public void SmartLog_10_Params_Structs_NoInlining()
    {
        for (int i = 0; i < Iterations; i++)
        {
            SmartLoggerExtensionsNoInlining.Log(logger, logLevel, eventId, ex, "message {a0} {a1} {a2} {a3} {a4} {a5} {a6} {a7} {a8} {a9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
        }
    }
}
