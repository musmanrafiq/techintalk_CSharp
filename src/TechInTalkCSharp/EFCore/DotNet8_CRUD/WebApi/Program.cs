using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Services;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<SchoolDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDb"));

            });

            // registration of services
            builder.Services.AddScoped<IUserService, UserService>();


            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();


            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
