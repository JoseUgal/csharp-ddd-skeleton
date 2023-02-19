using Crm.Projects.Domain;
using Crm.Projects.Infrastructure.Persistence;
using Crm.Shared.Infrastructure.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Backend.Extension.DependencyInjection;

public static class Infrastructure
{
    public static void AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<CrmContext>(options => 
            options.UseSqlServer(connectionString, serverOptions => serverOptions.EnableRetryOnFailure()),
            ServiceLifetime.Transient
        );
        
        services.AddScoped<DbContext, CrmContext>();

        services.AddScoped<ProjectRepository, EntityFrameworkProjectRepository>();
    }
}