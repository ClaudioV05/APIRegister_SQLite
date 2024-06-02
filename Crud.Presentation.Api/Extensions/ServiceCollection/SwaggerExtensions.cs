using Microsoft.OpenApi.Models;

namespace Crud.Presentation.Api.Extensions.ServiceCollection;

public static class SwaggerExtensions
{
    /// <summary>
    /// Configure swagger.
    /// </summary>
    /// <param name="services"></param>
    public static void ConfigureSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(config =>
        {
            config.SwaggerDoc("v1", new()
            {
                Version = "v1",
                Title = "CRUD_SQLServer",
                Description = "Simple CRUD"
            });

            config.AddSecurityDefinition("Bearer", new()
            {
                Scheme = "Bearer",
                BearerFormat = "JWT",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Description = "JWT Authorization header using the Bearer scheme."
            });
        });
    }
}