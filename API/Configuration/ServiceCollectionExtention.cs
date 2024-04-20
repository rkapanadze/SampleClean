

using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace API.Configuration;

internal static class ServiceCollectionExtention
{
    internal static void AddRepositories(this IServiceCollection services)
    {
    }

    internal static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options => { options.UseSqlite(configuration.GetConnectionString("DefaultConnection")); });
    }
}