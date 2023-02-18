using Crm.Projects.Domain;
using Crm.Shared.Infrastructure.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Crm.Projects.Infrastructure.Persistence;

public class EntityFrameworkProjectRepository : ProjectRepository
{
    private readonly CrmContext _context;

    public EntityFrameworkProjectRepository(CrmContext context)
    {
        _context = context;
    }
    
    public async Task Save(Project project)
    {
        await _context.Projects.AddAsync(project);
        await _context.SaveChangesAsync();
    }

    public async Task<Project?> Search(ProjectId id)
    {
        return await _context.Projects.FirstOrDefaultAsync(x => x.Id.Equals(id))!;
    }
}