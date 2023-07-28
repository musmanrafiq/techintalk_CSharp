using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // creating the builder
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            #region get requests 

            // all the endpoints
            app.MapGet("/", () =>
            {
                var forecast = "Welcome to the world of minimal APIs in dot net 7";
                return forecast;
            });

            app.MapGet("/SayHi", (string userName) =>
            {
                var forecast = $"Hi {userName}, welcome to the minimal apis";
                return forecast;
            });

            app.MapGet("/Users", () =>
            {
                var users = new List<User>
                {
                    new User(1, "Usman"),
                    new User(2, "Salman")
                };

                return users;
            });

            app.MapGet("/Users/{id}", (int id) =>
            {
                var users = new List<User>
                {
                    new User(1, "Usman"),
                    new User(2, "Salman")
                };

                return users.Where(x=>x.Id == id).FirstOrDefault();
            });

            app.MapGet("/Users/GetByName/{name}", (string name) =>
            {
                var users = new List<User>
                {
                    new User(1, "Usman"),
                    new User(2, "Salman")
                };

                return users.Where(x => x.Name.Contains(name)).ToList();
            });

            app.MapGet("/Users/Get", ([AsParameters] User user) =>
            {
                var users = new List<User>
                {
                    new User(1, "Usman"),
                    new User(2, "Salman")
                };

                return users.Where(x => x.Id == user.Id && x.Name == user.Name);
            });

            #endregion

            #region post requests

            app.MapPost("/Users", ([FromBody] User user) => {

                return user;
            });

            #endregion

            // rumming the application
            app.Run();
        }
    }

    record User (int Id, string Name);
}