using BenchmarkDotNet.Attributes;

namespace ConsoleApp.BestPracticesAndTips
{
    public class CountVsAny
    {
        public List<int> Items { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            Items = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        }

        [Benchmark]
        public void CheckCount()
        {
            if (Items.Count != 0)
            {
                Console.WriteLine("List is not empty");
            }
        }

        [Benchmark]
        public void CheckAny()
        {
            if (Items.Any())
            {
                Console.WriteLine("List is not empty");
            }
        }
    }
}
