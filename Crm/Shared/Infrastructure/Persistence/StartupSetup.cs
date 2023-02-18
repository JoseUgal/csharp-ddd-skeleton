using Crm.Projects.Domain;
using Crm.Projects.Infrastructure.Persistence;
using Crm.Shared.Infrastructure.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Crm.Shared.Infrastructure.Persistence;

public static class StartupSetup
{
    public static void AddDbContext(this IServiceCollection services, string connectionString)
    {
        services.AddScoped<DbContext, CrmContext>();

        services.AddScoped<ProjectRepository, EntityFrameworkProjectRepository>();
        
        services.AddDbContext<CrmContext>(
            options => options.UseSqlServer(connectionString, serverOptions => serverOptions.EnableRetryOnFailure()),
            ServiceLifetime.Transient
        );
    }
}