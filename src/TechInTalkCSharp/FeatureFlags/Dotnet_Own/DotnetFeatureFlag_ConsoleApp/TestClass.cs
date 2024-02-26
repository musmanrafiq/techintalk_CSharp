using Microsoft.Extensions.Configuration;

namespace DotnetFeatureFlag_ConsoleApp
{
    internal class TestClass
    {
        // config interface
        private readonly IConfiguration configuration;

        // injection of config
        public TestClass(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void PrintConfig()
        {
            Console.WriteLine($"{this.configuration["Test:Key"]} is coming from Test Class");
        }
    }
}