using Crm.Projects.Domain;
using Crm.Shared.Infrastructure.Persistence.EntityFramework.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Crm.Shared.Infrastructure.Persistence.EntityFramework;

public class CrmContext : DbContext
{
    public DbSet<Project> Projects { get; set; }

    public CrmContext(DbContextOptions<CrmContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProjectConfiguration());
    }
}