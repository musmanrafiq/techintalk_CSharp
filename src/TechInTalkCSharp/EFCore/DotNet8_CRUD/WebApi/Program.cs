using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Text.Json.Serialization;
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

            builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            var app = builder.Build();


            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }

    public class HeaderRemoverMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ImmutableList<string> _headersToRemove;

        public HeaderRemoverMiddleware(RequestDelegate next, ImmutableList<string> headersToRemove)
        {
            _next = next;
            _headersToRemove = headersToRemove;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.OnStarting(() =>
            {
                _headersToRemove.ForEach(header =>
                {
                    if (httpContext.Response.Headers.ContainsKey(header))
                    {
                        httpContext.Response.Headers.Remove(header);
                    }
                });

                return Task.FromResult(0);
            });

            await _next.Invoke(httpContext);
        }
    }

    public static class HeaderRemoverExtensions
    {
        public static IApplicationBuilder UseHeaderRemover(this IApplicationBuilder builder, params string[] headersToRemove)
        {
            return builder.UseMiddleware<HeaderRemoverMiddleware>(headersToRemove.ToImmutableList());
        }
    }
}
