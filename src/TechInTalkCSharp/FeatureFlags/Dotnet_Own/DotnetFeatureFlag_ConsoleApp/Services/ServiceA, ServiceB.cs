using DotnetFeatureFlag_ConsoleApp.Options;
using Microsoft.Extensions.Options;

namespace DotnetFeatureFlag_ConsoleApp.Services
{
    public class ServiceA
    {
        private TestOption _testOption;
        public ServiceA(IOptionsSnapshot<TestOption> options)
        {
            _testOption = options.Value;
        }

        public void Read()
        {
            Console.WriteLine($"Through IOptionsSnapshot pattren I am now getting {_testOption.Key}");
        }
    }

    public class ServiceB
    {

        private TestOption _testOption;
        public ServiceB(IOptionsMonitor<TestOption> options)
        {
            _testOption = options.CurrentValue;
            options.OnChange((newValue, old) =>
            {
                _testOption = newValue;
            });
        }

        public void Read()
        {
            Console.WriteLine($"Through IOptionsMonitor pattren I am now getting {_testOption.Key}");
        }
    }
}
