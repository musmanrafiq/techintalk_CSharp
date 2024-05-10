using BenchmarkDotNet.Attributes;

namespace Benchmarking.ConsoleApp
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class StringContains
    {
        public string Title { get; set; } = "Hi I am Usman Rafiq";

        [Benchmark]
        public bool ContainsRAsString()
        {
            return this.Title.Contains("R");
        }

        [Benchmark]
        public bool ContainsRAsChar()
        {
            return this.Title.Contains('R');
        }
    }
}
