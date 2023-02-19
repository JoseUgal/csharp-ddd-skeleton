using Shared.Domain.ValueObject;

namespace Crm.Projects.Domain;

public class ProjectName : StringValueObject
{
    public ProjectName(string value) : base(value)
    {
        EnsureLengthIsLessThan50Characters(value);
    }

    private void EnsureLengthIsLessThan50Characters(string value)
    {
        if (value.Length > 50) throw new ArgumentException($"{nameof(ProjectName)} can't have more than 50 characters");
    }
}