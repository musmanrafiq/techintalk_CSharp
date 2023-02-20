using Microsoft.Extensions.DependencyInjection;

namespace DIConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // all services configurations
            ServiceProvider services = ServicesDI();
            // game object 
            var gameObject = services.GetService<Game>();
            // game started
            gameObject.Start();

        }

        private static ServiceProvider ServicesDI()
        {
            var servicesCollection = new ServiceCollection();
            // lets list / add all the dependencies here
            servicesCollection.AddTransient<IEmailService, EmailService>();
            servicesCollection.AddSingleton<Game>();
            //servicesCollection.AddSingleton(typeof(Game));
            var services = servicesCollection.BuildServiceProvider();
            return services;
        }
    }
}