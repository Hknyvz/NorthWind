using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.WebAPI.Middlewares
{
    public class LogMiddleware
    {
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            ConnectionInfo connectionInfo = httpContext.Connection;

            HttpRequest httpRequest = httpContext.Request;
            return _next(httpContext);

        }
    }

    public static class LogMiddlewareExtensions
    {
        public static IApplicationBuilder UseLog(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogMiddleware>();
        }
    }
}

