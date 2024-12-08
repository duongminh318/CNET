using Demo.Domain.Exceptions;
using System.Text.Json;

namespace Demo.Api
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);

                await HandleExceptionAsync(httpContext, e);
            }
        }

        private async Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            if (exception is BaseException baseEx)
            {
                var response = new
                {
                    message = baseEx.Message,
                    status = baseEx.StatusCode,
                };
                httpContext.Response.ContentType = "application/json";

                httpContext.Response.StatusCode = (int)baseEx.StatusCode;

                await httpContext.Response.WriteAsync(JsonSerializer.Serialize(response));
            }
            else
            {
                var response = new
                {
                    message = "something when wrong!",
                    status = StatusCodes.Status400BadRequest,
                };
                httpContext.Response.ContentType = "application/json";

                httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;

                await httpContext.Response.WriteAsync(JsonSerializer.Serialize(response));
            }
        }

    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
