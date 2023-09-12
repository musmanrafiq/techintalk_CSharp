using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using WebApplication1.Middlewares;
using WebApplication1.Records;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region api setup
            // creating the builder
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<GlobalExceptionHandlingMiddleware>();
            var app = builder.Build();
            #endregion

            // in line database
            var users = new List<User>
            {
                new User(1, "A"),
                new User(2, "B"),
                new User(3, "C"),
                new User(4, "D") ,
                new User(5, "E")
            };

            // -------------- REST ---------------//

            #region get requests 

            // all the endpoints
            app.MapGet("/", () =>
            {

                var forecast = "Welcome to the world of minimal APIs in dot net 7";
                return TypedResults.Ok(forecast);

            });

            app.MapGet("/SayHi", (string userName) =>
            {
                var forecast = $"Hi {userName}, welcome to the minimal apis";
                return TypedResults.Ok(forecast);
            });

            app.MapGet("/Users", () =>
            {
                return TypedResults.Ok(users);
            });

            app.MapGet("/Users/{id}", (int id) =>
            {
                return TypedResults.Ok(users.Where(x => x.Id == id).FirstOrDefault());
            });

            app.MapGet("/Users/GetByName/{name}", (string name) =>
            {
                return TypedResults.Ok(users.Where(x => x.Name.Contains(name)).ToList());
            });

            app.MapGet("/Users/Get", ([AsParameters] User user) =>
            {
                return TypedResults.Ok(users.Where(x => x.Id == user.Id && x.Name == user.Name));
            });

            #endregion

            #region post requests

            app.MapPost("/Users", ([FromBody] User user) =>
            {
                users.Add(user);
                return TypedResults.Created($"/Users/{user.Id}");

            });

            app.MapPost("/Users", (string user) =>
            {
                var maxId = users.MaxBy(x => x.Id).Id;
                users.Add(new User(maxId + 1, user));
                return TypedResults.Created($"/Users/{user}");

            });

            app.MapPost("/Users/{userName}", (string userName) =>
            {
                var maxId = users.MaxBy(x => x.Id).Id;
                users.Add(new User(maxId + 1, userName));
                return TypedResults.Created($"/Users/{userName}"); ;

            });

            app.MapPost("/Users/Header", (HttpRequest request) =>
            {
                var testHeader = request.Headers.FirstOrDefault(x => x.Key == "test");
                // logic
                return TypedResults.Unauthorized();

            });

            #endregion

            #region http put requests

            app.MapPut("/Users/{userId}", (int userId, [FromBody] User user) =>
            {

                return TypedResults.NoContent();

            });

            #endregion

            #region http delete requests

            app.MapDelete("/Users/{userId}", (int userId) =>
            {
                return TypedResults.NoContent();
            });

            #endregion

            // -------------- End REST --------------//

            //------------------ Filters ------------------//

            #region get requests with filters

            app.MapGet("/filters/{name}", (string name) =>
            {
                var forecast = $"Hi {name}, welcome to the minimal apis";
                return TypedResults.Ok(forecast);
            })
            .AddEndpointFilter(async (invocationContext, next) =>
            {
                // running code before and after endpoint handler
                // inspect and process / modify the parameters
                // log information 
                // verify headers
                var userName = invocationContext.GetArgument<string>(0);
                if (userName != "usman")
                {
                    return Results.Problem("You are not allowed to this endpoint", statusCode: StatusCodes.Status401Unauthorized);

                }
                return await next(invocationContext);
            })
            .AddEndpointFilter(async (invocationContext, next) =>
            {

                var header = invocationContext.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "test");
                if (header.Value != "usman")
                {
                    return Results.Problem("You are not allowed to this endpoint, must have a header", statusCode: StatusCodes.Status401Unauthorized);

                }
                return await next(invocationContext);
            }); ;

            app.MapPost("/filters/", (User user) =>
            {
                var forecast = $"Hi {user.Name}, welcome to the minimal apis";
                return TypedResults.Ok(forecast);
            })
           .AddEndpointFilter(async (invocationContext, next) =>
           {
               // running code before and after endpoint handler
               // inspect and process / modify the parameters
               // log information 
               // verify headers
               var user = invocationContext.GetArgument<User>(0);
               if (user.Name != "usman")
               {
                   return Results.Problem("You are not allowed to this endpoint", statusCode: StatusCodes.Status401Unauthorized);

               }
               return await next(invocationContext);
           })
           .AddEndpointFilter(async (invocationContext, next) =>
           {

               var header = invocationContext.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "test");
               if (header.Value != "usman")
               {
                   return Results.Problem("You are not allowed to this endpoint, must have a header", statusCode: StatusCodes.Status401Unauthorized);

               }
               return await next(invocationContext);
           }); ;
            #endregion

            // ----------------- End Filters --------------//

            app.UseMiddleware<GlobalExceptionHandlingMiddleware>();

            // enable static content in minimal apis
            app.UseFileServer(new FileServerOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),
                "StaticContent"))
            });

            #region starting the api
            // rumming the application
            app.Run();
            #endregion
        }
    }
}