namespace Crud.Presentation.Api.Extensions.ApplicationBuilder;

public static class SwaggerExtensions
{
    /// <summary>
    /// Configure swagger.
    /// </summary>
    /// <param name="app"></param>
    public static void ConfigureSwagger(this IApplicationBuilder app)
    {
        app.UseSwagger();

        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Crud");
            options.InjectStylesheet("/swagger-ui/custom.css");
            options.EnableTryItOutByDefault();
        });

        app.Use(async (context, next) =>
        {
            if (context.Request.Path == $"/{nameof(Crud)}")
            {
                context.Response.Redirect("/swagger/index.html");
                return;
            }

            await next();
        });
    }
}