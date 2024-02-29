using DotnetFeatureFlag_ConsoleApp.Options;
using Microsoft.Extensions.Options;

namespace DotnetFeatureFlag_ConsoleApp
{
    public class TestClassTwo
    {
        private TestOption _testOption;
        public TestClassTwo(IOptions<TestOption> options)
        {
            _testOption = options.Value;
        }

        public void Read()
        {
            Console.WriteLine($"Through IOptions pattren I am now getting {_testOption.Key}");
        }
    }
}
