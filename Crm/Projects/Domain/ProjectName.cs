using Shared.Domain.ValueObject;

namespace Crm.Projects.Domain;

public class ProjectName : StringValueObject
{
    public ProjectName(string value) : base(value)
    {
        EnsureLegthIsLessThan50Characters(value);
    }

    private void EnsureLegthIsLessThan50Characters(string value)
    {
        if (value.Length > 30) throw new ArgumentException($"{nameof(ProjectName)} can't have more than 30 characters");
    }
}