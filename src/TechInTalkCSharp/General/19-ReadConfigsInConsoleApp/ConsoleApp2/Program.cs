using Microsoft.Extensions.Configuration;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binder = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appConfig.json");

            IConfiguration configuration = binder.Build();
            var emailSetting = configuration.GetSection("EmailService").Get<EmailServiceConfig>();

            Console.WriteLine($"Email is {emailSetting.Email}, smtp is {emailSetting.Smtp} and the password is" +
                $" {emailSetting.Password}");
        }
    }

    public class EmailServiceConfig
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Smtp { get; set; }
    }
}
