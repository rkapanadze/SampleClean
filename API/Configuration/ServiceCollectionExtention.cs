using Application.Common.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Interceptors;
using Persistence.Repositories;

namespace API.Configuration;

internal static class ServiceCollectionExtention
{
    internal static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IDriversRepository, DriversRepository>();
    }

    internal static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment env)
    {
        services.AddDbContext<AppDbContext>((sp, opts) =>
        {
            var auditableInterceptor = sp.GetService<UpdateAuditableEntitiesInterceptor>()!;
        
            if (env.IsDevelopment())
            {
                opts.UseSqlite(configuration.GetConnectionString("DefaultConnection"))
                    .AddInterceptors(auditableInterceptor);
            }
            else
            {
                opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                    .AddInterceptors(auditableInterceptor);
            }
        });
    }
}