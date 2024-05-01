using Crud.Presentation.Api.Models;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace Crud.Presentation.Api.Extensions;

public static class CrudExceptionMiddlewareExtensions
{
    public static void ConfigureExceptionHandler(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                if (contextFeature != null)
                {
                    await context.Response.WriteAsync(new ErrorDetails()
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = contextFeature.Error.Message
                        /*
                         * This two fields take in file of log.
                         * 
                        Source = contextFeature.Error.Source,
                        StackTrace = contextFeature.Error.StackTrace,
                        */
                    }.ToString());
                }
            });
        });
    }
}