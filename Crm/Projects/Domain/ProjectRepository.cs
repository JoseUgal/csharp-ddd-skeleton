namespace Crm.Projects.Domain;

public interface ProjectRepository
{
    Task Save(Project project);
    Task<Project?> Search(ProjectId id);
}