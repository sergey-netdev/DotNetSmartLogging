namespace DotNetSmartLogging.Tests;

/// <summary>
/// Contains copies of the corresponding methods of <see cref="SmartLoggerExtensions"/> 
/// without <see cref="System.Runtime.CompilerServices.MethodImplAttribute"/> applied.
/// 
/// Note, these are *not* extension methods,
/// otherwise we have methos resolution issue in <see cref="PerformanceBoxingNamespaceTest"/>.
/// </summary>
internal static class SmartLoggerExtensionsNoInlining
{
#pragma warning disable CA2254 // Template should be a static expression
    public static void Log<T0, T1>(ILogger logger, LogLevel logLevel, EventId eventId, Exception? exception, string? message, T0 arg0, T1 arg1)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(logLevel))
        {
            LoggerExtensions.Log(logger, logLevel, eventId, exception, message, arg0, arg1);
        }
    }

    public static void Log<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ILogger logger, LogLevel logLevel, EventId eventId, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(logLevel))
        {
            LoggerExtensions.Log(logger, logLevel, eventId, exception, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
    }
}