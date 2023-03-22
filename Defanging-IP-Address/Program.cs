using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;


var config = new ManualConfig()
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .AddValidator(JitOptimizationsValidator.DontFailOnError)
    .AddLogger(ConsoleLogger.Default)
    .AddColumnProvider(DefaultColumnProviders.Instance);

BenchmarkRunner.Run<Solution>(config);

[MemoryDiagnoser]
public class Solution {
    [Benchmark]
    
    [Arguments("1.1.1.1")]
    public string DefangIPaddrOne(string address)
    {
        return address.Replace(".", "[.]");
    }
    [Benchmark]
    [Arguments("1.1.1.1")]
    public string DefangIPaddrTwo(string address)
    {
        var output = String.Empty;
        char[] arr = address.ToCharArray();
        for (int i = 0; i < address.Length; i++)
        {
            if (arr[i].Equals('.'))
                output += "[.]";
            else
                output += arr[i];
        }

        return output;
    }
}