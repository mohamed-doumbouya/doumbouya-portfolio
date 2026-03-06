using Microsoft.EntityFrameworkCore;
using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Models;
using MyPortfolio.Infrastructure.Data;
using MyPortfolio.Infrastructure.Repositories.Generics;
using System.Threading.Tasks;

namespace MyPortfolio.Infrastructure.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Project?> GetProjectWithCategoryAsync(int id)
        {
            return await _dbContext.Projects
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
