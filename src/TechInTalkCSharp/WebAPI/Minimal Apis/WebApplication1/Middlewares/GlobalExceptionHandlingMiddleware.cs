using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace WebApplication1.Middlewares
{
    public class GlobalExceptionHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                ProblemDetails details = new()
                {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Type = "Server Error",
                    Title = "Server Error",
                    Detail = $"{ex.Message}_{Guid.NewGuid}"
                };
                string jsonResponse = JsonSerializer.Serialize(details);
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(jsonResponse);

            }
        }
    }
}
