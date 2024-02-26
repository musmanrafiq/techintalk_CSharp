using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetFeatureFlag_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // builder object with configurations loaded from json file
            var builder = new ConfigurationBuilder().AddJsonFile("appSettings.json", false, true);
            // building configs
            var config = builder.Build();

            // First video
            var testKey = config["TestKey"];
            Console.WriteLine(testKey);

            //
            var serviceProvider = new ServiceCollection()
                .AddSingleton<TestClass>()
                .AddSingleton<IConfiguration>(config)
                .BuildServiceProvider();

            // Second Video
            var testValueFromObj = config["Test:Key"];
            var testValueFromObjUsingGetSection = config.GetSection("Test:Key");
            Console.WriteLine(testValueFromObj);
            Console.WriteLine(testValueFromObjUsingGetSection.Value);

            TestClass testClassObj = serviceProvider.GetService<TestClass>();

            testClassObj?.PrintConfig();

        }
    }
}
