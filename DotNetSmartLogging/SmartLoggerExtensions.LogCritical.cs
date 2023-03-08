namespace Microsoft.Extensions.Logging.Smart;

public static partial class SmartLoggerExtensions
{
#pragma warning disable CA2254 // Template should be a static expression

    #region LogCritical<T0..T9>(this ILogger logger, string? message, T0 arg0..T9 arg9)
    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0>(this ILogger logger, string? message, T0 arg0)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId: 0, exception: null, message, arg0);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1>(this ILogger logger, string? message, T0 arg0, T1 arg1)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId: 0, exception: null, message, arg0, arg1);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2>(this ILogger logger, string? message, T0 arg0, T1 arg1, T2 arg2)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId: 0, exception: null, message, arg0, arg1, arg2);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3>(this ILogger logger, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId: 0, exception: null, message, arg0, arg1, arg2, arg3);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4>(this ILogger logger, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId: 0, exception: null, message, arg0, arg1, arg2, arg3, arg4);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5>(this ILogger logger, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId: 0, exception: null, message, arg0, arg1, arg2, arg3, arg4, arg5);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6>(this ILogger logger, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId: 0, exception: null, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6, T7>(this ILogger logger, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId: 0, exception: null, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this ILogger logger, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId: 0, exception: null, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ILogger logger, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId: 0, exception: null, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
    }
    #endregion

    #region LogCritical<T0..T9>(this ILogger logger, EventId eventId, string? message, T0 arg0..T9 arg9)
    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0>(this ILogger logger, EventId eventId, string? message, T0 arg0)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception: null, message, arg0);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1>(this ILogger logger, EventId eventId, string? message, T0 arg0, T1 arg1)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception: null, message, arg0, arg1);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2>(this ILogger logger, EventId eventId, string? message, T0 arg0, T1 arg1, T2 arg2)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception: null, message, arg0, arg1, arg2);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3>(this ILogger logger, EventId eventId, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception: null, message, arg0, arg1, arg2, arg3);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4>(this ILogger logger, EventId eventId, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception: null, message, arg0, arg1, arg2, arg3, arg4);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5>(this ILogger logger, EventId eventId, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception: null, message, arg0, arg1, arg2, arg3, arg4, arg5);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6>(this ILogger logger, EventId eventId, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception: null, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6, T7>(this ILogger logger, EventId eventId, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception: null, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this ILogger logger, EventId eventId, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception: null, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ILogger logger, EventId eventId, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception: null, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
    }
    #endregion

    #region LogCritical<T0..T9>(this ILogger logger, Exception? exception, string? message, T0 arg0..T9 arg9)
    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0>(this ILogger logger, Exception? exception, string? message, T0 arg0)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, 0, exception, message, arg0);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1>(this ILogger logger, Exception? exception, string? message, T0 arg0, T1 arg1)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, 0, exception, message, arg0, arg1);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2>(this ILogger logger, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, 0, exception, message, arg0, arg1, arg2);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3>(this ILogger logger, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, 0, exception, message, arg0, arg1, arg2, arg3);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4>(this ILogger logger, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, 0, exception, message, arg0, arg1, arg2, arg3, arg4);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5>(this ILogger logger, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, 0, exception, message, arg0, arg1, arg2, arg3, arg4, arg5);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6>(this ILogger logger, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, 0, exception, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6, T7>(this ILogger logger, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, 0, exception, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this ILogger logger, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, 0, exception, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ILogger logger, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, 0, exception, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
    }
    #endregion

    #region LogCritical<T0..T9>(this ILogger logger, EventId eventId, Exception? exception, string? message, T0 arg0..T9 arg9)
    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0>(this ILogger logger, EventId eventId, Exception? exception, string? message, T0 arg0)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception, message, arg0);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1>(this ILogger logger, EventId eventId, Exception? exception, string? message, T0 arg0, T1 arg1)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception, message, arg0, arg1);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2>(this ILogger logger, EventId eventId, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception, message, arg0, arg1, arg2);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3>(this ILogger logger, EventId eventId, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception, message, arg0, arg1, arg2, arg3);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4>(this ILogger logger, EventId eventId, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception, message, arg0, arg1, arg2, arg3, arg4);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5>(this ILogger logger, EventId eventId, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception, message, arg0, arg1, arg2, arg3, arg4, arg5);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6>(this ILogger logger, EventId eventId, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6, T7>(this ILogger logger, EventId eventId, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this ILogger logger, EventId eventId, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
    }

    ///<inheritdoc cref="LoggerExtensions.LogCritical(ILogger, EventId, Exception, string?, object?[])"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void LogCritical<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ILogger logger, EventId eventId, Exception? exception, string? message, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        if (logger.IsEnabled(LogLevel.Critical))
        {
            LoggerExtensions.LogCritical(logger, eventId, exception, message, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
    }
    #endregion
}
