namespace DotNetSmartLogging.Tests;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging.Smart; // if this line is commented the test result will show allocs (boxing)

/// <summary>
/// With <c>using Microsoft.Extensions.Logging.Smart;</c>:
/// <![CDATA[
/// |                Method |     Mean |     Error |    StdDev | Allocated |
/// |---------------------- |---------:|----------:|----------:|----------:|
/// | Log_10_Params_Structs | 6.020 ns | 0.9961 ns | 0.0546 ns |         - |
/// ]]>
/// 
/// Without <c>using Microsoft.Extensions.Logging.Smart;</c>:
/// <![CDATA[
/// |                Method |     Mean |    Error |   StdDev |   Gen0 | Allocated |
/// |---------------------- |---------:|---------:|---------:|-------:|----------:|
/// | Log_10_Params_Structs | 150.5 ns | 673.4 ns | 36.91 ns | 0.0329 |     344 B |
/// ]]>
/// </summary>
[MemoryDiagnoser]
public class PerformanceBoxingNamespaceTest
{
    private ILogger logger = NullLogger.Instance;

    [Benchmark]
    public void Log_10_Params_Structs() =>
        logger.Log(LogLevel.Information, new EventId(), null, "message {a0} {a1} {a2} {a3} {a4} {a5} {a6} {a7} {a8} {a9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
}
