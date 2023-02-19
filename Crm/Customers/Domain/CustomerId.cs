using Shared.Domain.ValueObject;

namespace Crm.Customers.Domain;

public class CustomerId : Uuid
{
    public CustomerId(string value) : base(value)
    {
    }
}