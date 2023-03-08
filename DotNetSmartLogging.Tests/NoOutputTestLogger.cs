namespace DotNetSmartLogging.Tests;

/// <summary>
/// <see cref="Microsoft.Extensions.Logging.Abstractions.NullLoggerNullLogger"/> does not format a message
/// but we need to do it when testing scenarios with <see cref="ILogger.IsEnabled(LogLevel)"/> <c>true</c>.
/// </summary>
class NoOutputTestLogger : ILogger
{
    private readonly LogLevel? _enabledLogLevel;

    public NoOutputTestLogger(LogLevel? enabledLogLevel = null)
    {
        _enabledLogLevel = enabledLogLevel;
    }

    public string? LastMessage { get; internal set; }

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull => throw new NotImplementedException();

    public bool IsEnabled(LogLevel logLevel) => _enabledLogLevel.HasValue && _enabledLogLevel.Value == logLevel;

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        ArgumentNullException.ThrowIfNull(formatter, nameof(formatter));

        if (IsEnabled(logLevel))
        {
            LastMessage = formatter(state, exception); // just format, no output needed
            // Note, the default formatter ignores exceptions but it's OK for our purpose.
        }
        else
        {
            LastMessage = null;
        }
    }
}
