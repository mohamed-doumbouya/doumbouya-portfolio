using Microsoft.EntityFrameworkCore;
using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Models;
using MyPortfolio.Infrastructure.Data;
using MyPortfolio.Infrastructure.Repositories.Generics;
using System.Threading.Tasks;

namespace MyPortfolio.Infrastructure.Repositories
{
    public class ResumeRepository : GenericRepository<Resume>, IResumeRepository
    {
        public ResumeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Resume> GetResumeAsync()
        {
            var resume = await _entities
                .Include(r => r.Educations)
                .Include(r => r.Experiences)
                .ThenInclude(e => e.Missions)
                .AsSplitQuery()
                .FirstOrDefaultAsync();

            return resume;
        }
    }
}
