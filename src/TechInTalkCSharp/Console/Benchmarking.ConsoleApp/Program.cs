using BenchmarkDotNet.Running;

namespace Benchmarking.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StringContains>();

        }
    }
}
