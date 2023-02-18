using Shared.Domain.Aggregate;

namespace Crm.Projects.Domain;

public class Project : AggregateRoot
{
    public ProjectId Id { get; }

    public ProjectName Name { get; }

    public Project(ProjectId id, ProjectName name)
    {
        Id = id;
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        if (this == obj) return true;

        if (obj is not Project item) return false;

        return Id.Equals(item.Id) && Name.Equals(item.Name);
    }

    public override int GetHashCode() => HashCode.Combine(Id, Name);
}