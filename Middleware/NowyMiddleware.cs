using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    public class NowyMiddleware
    {
        private RequestDelegate _next;
        public NowyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            var przegladarka = context.Request.Headers["User-Agent"];
            var szukaj = przegladarka.ToString().ToLower().Contains("edg") || przegladarka.ToString().ToLower().Contains("trident");

            if (szukaj)
            {
                context.Response.WriteAsync("Przegladarka nie jest obslugiwana");
            }
            return _next(context);

        }
    }
}

   