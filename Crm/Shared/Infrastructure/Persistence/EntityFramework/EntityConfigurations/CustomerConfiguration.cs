using Crm.Customers.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shared.Infrastructure.Persistence.EntityFramework.Extension;

namespace Crm.Shared.Infrastructure.Persistence.EntityFramework.EntityConfigurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(x => x.Id);

        builder.ToTable(nameof(CrmContext.Customers).ToDatabaseFormat());

        builder.Property(x => x.Id)
            .HasConversion(v => v.Value, v => new CustomerId(v))
            .HasColumnName(nameof(Customer.Id).ToDatabaseFormat());
        
        builder.Property(x => x.Name)
            .HasConversion(v => v.Value, v => new CustomerName(v))
            .HasColumnName(nameof(Customer.Name).ToDatabaseFormat());
    }
}