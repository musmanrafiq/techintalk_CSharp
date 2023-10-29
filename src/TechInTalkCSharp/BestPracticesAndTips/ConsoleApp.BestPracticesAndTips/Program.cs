using BenchmarkDotNet.Running;

namespace ConsoleApp.BestPracticesAndTips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<CountVsAny>();

        }
    }


}