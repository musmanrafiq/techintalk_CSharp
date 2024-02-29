using DotnetFeatureFlag_ConsoleApp.Options;
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

            // Second video
            var servicesCollection = new ServiceCollection()
                .AddSingleton<TestClass>()
                .AddSingleton<TestClassTwo>()
                .AddSingleton<IConfiguration>(config);

            // Third video
            // Mappting Test config from config file to the TestOption class
            // to be available in DI as IOptions
            servicesCollection.Configure<TestOption>(config.GetSection("Test"));

            // creating the provider
            var serviceProvider = servicesCollection.BuildServiceProvider();

            // Second Video
            var testValueFromObj = config["Test:Key"];
            var testValueFromObjUsingGetSection = config.GetSection("Test:Key");
            Console.WriteLine(testValueFromObj);
            Console.WriteLine(testValueFromObjUsingGetSection.Value);

            TestClass testClassObj = serviceProvider.GetService<TestClass>();
            TestClassTwo testClassTwoObj = serviceProvider.GetService<TestClassTwo>();


            testClassObj?.PrintConfig();
            testClassTwoObj.Read();

        }
    }
}
