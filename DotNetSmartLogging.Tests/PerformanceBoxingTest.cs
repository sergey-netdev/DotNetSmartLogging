namespace DotNetSmartLogging.Tests;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Logging.Smart;

[MemoryDiagnoser]
public class PerformanceBoxingTest
{
    private const LogLevel logLevel = LogLevel.Information;
    private readonly Exception ex = new();
    private readonly EventId eventId = new(0, nameof(PerformanceBoxingTest));
    private ILogger? logger;

    [GlobalSetup]
    public void Setup()
    {
        logger = new NoOutputTestLogger(LoggerEnabled ? logLevel : null);
    }

    [Params(true, false)]
    public bool LoggerEnabled;

    [Benchmark]
    public void SmartLog_1_Params_Structs() =>
        SmartLoggerExtensions.Log(logger!, logLevel, eventId, ex, "message {a0}", 0);

    [Benchmark]
    public void SmartLog_2_Params_Structs() =>
        SmartLoggerExtensions.Log(logger!, logLevel, eventId, ex, "message {a0} {a1}", 0, 1);

    [Benchmark]
    public void SmartLog_10_Params_Structs() =>
        SmartLoggerExtensions.Log(logger!, logLevel, eventId, ex, "message {a0} {a1} {a2} {a3} {a4} {a5} {a6} {a7} {a8} {a9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);


    [Benchmark]
    public void SmartLog_1_Params_Objects() =>
        SmartLoggerExtensions.Log(logger!, logLevel, eventId, ex, "message {a0}", "0");

    [Benchmark]
    public void SmartLog_2_Params_Objects() =>
        SmartLoggerExtensions.Log(logger!, logLevel, eventId, ex, "message {a0} {a1}", "0", "1");

    [Benchmark]
    public void SmartLog_10_Params_Objects() =>
        SmartLoggerExtensions.Log(logger!, logLevel, eventId, ex, "message {a0} {a1} {a2} {a3} {a4} {a5} {a6} {a7} {a8} {a9}", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9");



    [Benchmark]
    public void DefaultLog_1_Params_Structs() =>
        LoggerExtensions.Log(logger!, logLevel, eventId, ex, "message {a0}", 0);

    [Benchmark]
    public void DefaultLog_2_Params_Structs() =>
        LoggerExtensions.Log(logger!, logLevel, eventId, ex, "message {a0} {a1}", 0, 1);

    [Benchmark]
    public void DefaultLog_10_Params_Structs() =>
        LoggerExtensions.Log(logger!, logLevel, eventId, ex, "message {a0} {a1} {a2} {a3} {a4} {a5} {a6} {a7} {a8} {a9}", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);


    [Benchmark]
    public void DefaultLog_1_Params_Objects() =>
        LoggerExtensions.Log(logger!, logLevel, eventId, ex, "message {a0}", "0");

    [Benchmark]
    public void DefaultLog_2_Params_Objects() =>
        LoggerExtensions.Log(logger!, logLevel, eventId, ex, "message {a0} {a1}", "0", "1");

    [Benchmark]
    public void DefaultLog_10_Params_Objects() =>
        LoggerExtensions.Log(logger!, logLevel, eventId, ex, "message {a0} {a1} {a2} {a3} {a4} {a5} {a6} {a7} {a8} {a9}", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9");
}
