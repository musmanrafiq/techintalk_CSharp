using Microsoft.Extensions.Configuration;

namespace DotnetFeatureFlag_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var builder = new ConfigurationBuilder().AddJsonFile("appSettings.json", false, true);

            var config = builder.Build();

            var testKey = config["TestKey"];

            Console.WriteLine($"Hello, World! {testKey}");

            Console.ReadKey();

            Console.WriteLine($"Hello, World! {testKey}");
        }
    }
}
