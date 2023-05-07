using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Middleware
{
    public class TestMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // context.s
        }
    }
}