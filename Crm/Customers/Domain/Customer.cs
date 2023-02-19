using Shared.Domain.Aggregate;

namespace Crm.Customers.Domain;

public class Customer : AggregateRoot
{
    public CustomerId Id { get; }

    public CustomerName Name { get; }

    public Customer(CustomerId id, CustomerName name)
    {
        Id = id;
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        if (this == obj) return true;

        if (obj is not Customer item) return false;

        return Id.Equals(item.Id) && Name.Equals(item.Name);
    }

    public override int GetHashCode() => HashCode.Combine(Id, Name);
}