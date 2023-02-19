using Shared.Domain.ValueObject;

namespace Crm.Customers.Domain;

public class CustomerName : StringValueObject
{
    public CustomerName(string value) : base(value)
    {
        EnsureLengthIsLessThan50Characters(value);
    }
    
    private void EnsureLengthIsLessThan50Characters(string value)
    {
        if (value.Length > 50) throw new ArgumentException($"{nameof(CustomerName)} can't have more than 50 characters");
    }
}