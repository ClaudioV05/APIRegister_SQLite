using Crud.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Crud.Presentation.Api.Extensions.ServiceCollection;

public static class DatabaseProviderExtensions
{
    /// <summary>
    /// Configure database dependencies.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    public static void ConfigureDatabaseDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        var connection = configuration["ConnectionStrings:DatabaseConnection"]?.ToString();

        services.AddDbContext<DatabaseContext>(options =>
        {
            options.UseSqlServer(connection, configure =>
            {
                configure.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds);
                configure.MigrationsAssembly(configuration["PresentationProjectName"]);
            });
        });
    }
}