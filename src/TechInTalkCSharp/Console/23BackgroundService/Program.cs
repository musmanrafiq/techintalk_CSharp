using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _23BackgroundService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureHostConfiguration(hconfig => { })
                .ConfigureServices((context, services) =>
                {
                    services.AddHostedService<MyProcessor>();
                }).UseConsoleLifetime().Build();
            host.Run();
        }
    }

    public class MyProcessor : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine($"The current date is {DateTime.Now.Date}");
                await Task.Delay(1000);
            }
            return;
        }
    }
}