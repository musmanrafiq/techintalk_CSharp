namespace Configs.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //app.UseHttpsRedirection();
            //app.UseAuthorization();


            app.MapGet("/weatherforecast", (HttpContext httpContext, IConfiguration config) =>
            {
                var userName = config.GetSection("UserList").Get<List<User>>()[0].Name;

                var userSettings = config.GetSection("Users").Get<UserSetting>();
                return userSettings;
            });

            app.Run();
        }
    }

    public record UserSetting
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
    public record User
    {
        public string Name { get; set; }
    }
}
