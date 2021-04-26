using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware
{
    public static class BrowserMiddlewareExtensions
    {     
            public static IApplicationBuilder UseNowyMiddleware(this IApplicationBuilder builder)
            {

                return builder.UseMiddleware<NowyMiddleware>();
            }
    }
}



