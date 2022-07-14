﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.Features;
using System.Net;
using Utils.ErrorModels;

namespace DiplomskiRad.Middlewares
{
    public static class ExceptionMiddleware
    {

        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.ContentType = "text/javascript";

                    var contextResponse = context.Features.Get<IHttpResponseFeature>();
                    var contextError = context.Features.Get<IExceptionHandlerFeature>();

                    if(contextError != null)
                    {
                        if(contextError.Error is BadRequestError)
                        {
                            contextResponse.StatusCode = (int)HttpStatusCode.BadRequest;
                            await context.Response.WriteAsync(contextError.Error.Message);
                        }

                        if (contextError.Error is UnautorizedError)
                        {
                            contextResponse.StatusCode = (int)HttpStatusCode.Unauthorized;
                            await context.Response.WriteAsync(contextError.Error.Message);
                        }

                        if (contextError.Error is InternalServerError)
                        {
                            contextResponse.StatusCode = (int)HttpStatusCode.InternalServerError;
                            await context.Response.WriteAsync(contextError.Error.Message);
                        }
                    }
                }
                );
            });
        }
    }
}
