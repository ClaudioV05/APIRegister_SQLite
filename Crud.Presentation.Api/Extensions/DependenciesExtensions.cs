using Crud.Presentation.Api.Filters;

namespace Crud.Presentation.Api.Extensions;

public static class DependenciesExtensions
{
    /// <summary>
    /// Configure dependencies.
    /// </summary>
    /// <param name="services"></param>
    public static void ConfigureDependencies(this IServiceCollection services)
    {
        services.AddScoped<FilterActionContextController>();
        services.AddScoped<FilterActionContextLog>();
    }
}