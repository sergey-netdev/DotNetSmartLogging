namespace DotNetSmartLogging.Tests;

using Microsoft.Extensions.Logging.Smart;
using System.Reflection;
using Xunit;

/// <summary>
/// The tests here make sure there are no typos in <see cref="SmartLoggerExtensions"/>
/// and the calls are properly forwared to <see cref="LoggerExtensions"/>.
/// Trouble is, for every method in <see cref="LoggerExtensions"/> there are 10 methods
/// in <see cref="SmartLoggerExtensions"/> so it would be stupid to write regular tests.
/// Instead, .NET reflection is used to make things easier.
/// </summary>
public class SmartLoggerExtensionsTests
{
    private readonly ITestOutputHelper testOutputHelper;
    private readonly Type testGenericParamType = typeof(int); // let's use int as values for T0..T9 params

    public SmartLoggerExtensionsTests(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void All_Log_Methods_Properly_Format_Message() => TestMethodSet("Log", LogLevel.Information, expectedNumberOfMethods: 4 * 10);

    [Fact]
    public void All_LogCritical_Methods_Properly_Format_Message() => TestMethodSet("LogCritical", LogLevel.Critical, expectedNumberOfMethods: 4 * 10);

    [Fact]
    public void All_LogDebug_Methods_Properly_Format_Message() => TestMethodSet("LogDebug", LogLevel.Debug, expectedNumberOfMethods: 4 * 10);

    [Fact]
    public void All_LogError_Methods_Properly_Format_Message() => TestMethodSet("LogError", LogLevel.Error, expectedNumberOfMethods: 4 * 10);

    [Fact]
    public void All_LogInformation_Methods_Properly_Format_Message() => TestMethodSet("LogInformation", LogLevel.Information, expectedNumberOfMethods: 4 * 10);

    [Fact]
    public void All_LogTrace_Methods_Properly_Format_Message() => TestMethodSet("LogTrace", LogLevel.Trace, expectedNumberOfMethods: 4 * 10);

    [Fact]
    public void All_LogWarning_Methods_Properly_Format_Message() => TestMethodSet("LogWarning", LogLevel.Warning, expectedNumberOfMethods: 4 * 10);

    private void TestMethodSet(string methodSetName, LogLevel logLevel, int expectedNumberOfMethods)
    {
        MethodInfo[] methods = typeof(SmartLoggerExtensions)
            .GetMethods(BindingFlags.Static | BindingFlags.Public)
            .Where(x => x.Name == methodSetName)
            .ToArray();
        Assert.Equal(expectedNumberOfMethods, methods.Length);

        foreach (MethodInfo method in methods)
        {
            Assert.True(method.ContainsGenericParameters);
            TestMethod(method, logLevel);
        }
    }

    private void TestMethod(MethodInfo method, LogLevel logLevel)
    {
        this.testOutputHelper.WriteLine($"Testing method {method}...");

        NoOutputTestLogger logger = new(logLevel);
        Exception ex = new("Bummer");
        EventId eventId = new(Random.Shared.Next());
        int testGenericParamValue = 0;

        // get all and generic param types
        Type[] methodParamTypes = method.GetParameters()
            .Select(x => x.ParameterType.IsGenericParameter ? testGenericParamType : x.ParameterType) // replace T0..T9 with int
            .ToArray();

        Type[] methodGenericParamTypes = methodParamTypes
            .Where(x => x == testGenericParamType)
            .ToArray();

        // generate log message template and the expected final message
        string messageTemplate = $"{method.Name} event {eventId}";
        string expectedMessage = messageTemplate;
        for (int i = 0; i < methodGenericParamTypes.Length; i++)
        {
            messageTemplate += $" {{arg{i}}}";
            expectedMessage += $" {i}";
        }

        this.testOutputHelper.WriteLine($"\tTemplate:\t{messageTemplate}");
        this.testOutputHelper.WriteLine($"\tExpected:\t{expectedMessage}");

        // generate param values
        object[] preparedMethodParamValues = methodParamTypes
            .Select(x => PrepareMethodParam(x, messageTemplate))
            .ToArray();

        // call and test
        MethodInfo genericMethod = method.MakeGenericMethod(methodGenericParamTypes);
        genericMethod.Invoke(logger, preparedMethodParamValues);

        this.testOutputHelper.WriteLine($"\tLogged:\t\t{logger.LastMessage}");
        Assert.Equal(expectedMessage, logger.LastMessage);

        object PrepareMethodParam(Type methodParamType, string testMessageTemplate)
        {
            if (methodParamType == typeof(ILogger))
            {
                return logger;
            }
            else if (methodParamType == typeof(LogLevel))
            {
                return logLevel;
            }
            else if (methodParamType == typeof(EventId))
            {
                return eventId;
            }
            else if (methodParamType == typeof(Exception))
            {
                return ex;
            }
            else if (methodParamType == typeof(string))
            {
                return testMessageTemplate;
            }
            else if (methodParamType == testGenericParamType)
            {
                return testGenericParamValue++;
            }
            else
            {
                throw new InvalidOperationException($"Type '{methodParamType.FullName}' is not expected.");
            }
        }
    }
}
