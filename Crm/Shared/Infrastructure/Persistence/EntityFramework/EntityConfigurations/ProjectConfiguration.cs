using Crm.Projects.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shared.Infrastructure.Persistence.EntityFramework.Extension;

namespace Crm.Shared.Infrastructure.Persistence.EntityFramework.EntityConfigurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable(nameof(CrmContext.Projects).ToDatabaseFormat());

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasConversion(v => v.Value, v => new ProjectId(v))
            .HasColumnName(nameof(Project.Id).ToDatabaseFormat());
        
        builder.Property(x => x.Name)
            .HasConversion(v => v.Value, v => new ProjectName(v))
            .HasColumnName(nameof(Project.Name).ToDatabaseFormat());
    }
}