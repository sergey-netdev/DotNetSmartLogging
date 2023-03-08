namespace DotNetSmartLogging.Tests;
using BenchmarkDotNet.Running;

public static class Program
{
    /// <summary>
    /// <para>
    /// Allows to run the performance tests from the cmd.
    /// </para>
    /// <para>
    /// <c>dotnet run -c Release --filter "*Performance*"</c>
    /// </para>
    /// </summary>
    public static void Main(string[] args)
    {
        //  dotnet run -c Release -- --job short --runtimes netcoreapp3.1 --filter *ContextQueryTests*
        BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
