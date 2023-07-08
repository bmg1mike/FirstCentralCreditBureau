using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Serilog;

namespace API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IDiagnosticContext _diagnosticContext;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IDiagnosticContext diagnosticContext)
        {
            this.next = next;
            _logger = logger;
            _diagnosticContext = diagnosticContext;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                context.Response.Headers.Remove("X-AspNet-Version");
                context.Response.Headers.Remove("X-Powered-By");
                await next(context);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    _logger.LogError("{ExceptionType} {ExceptionMessage}", ex.InnerException.GetType().ToString(), ex.InnerException.Message);
                }
                else
                {
                    _logger.LogError("{ExceptionType} {ExceptionMessage}", ex.GetType().ToString(), ex.Message);
                }
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await context.Response.WriteAsync("An Error occurred, please try again later.");

            }

        }
    }
}