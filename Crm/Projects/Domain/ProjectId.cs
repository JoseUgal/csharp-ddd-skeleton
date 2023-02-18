using Shared.Domain.ValueObject;

namespace Crm.Projects.Domain;

public class ProjectId : Uuid
{
    public ProjectId(string value) : base(value)
    {
    }
}