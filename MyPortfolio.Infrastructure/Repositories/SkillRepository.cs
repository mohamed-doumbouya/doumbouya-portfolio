using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Models;
using MyPortfolio.Infrastructure.Data;
using MyPortfolio.Infrastructure.Repositories.Generics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Infrastructure.Repositories
{
    public class SkillRepository : GenericRepository<Skill>, ISkillRepository
    {
        public SkillRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Skill>> GetSkillsByUserIdAsync(string userId)
        {
            var skills = _dbContext.Skills.Where(s => s.UserId == userId).ToList();

            return await Task.FromResult(skills);
        }
    }
}
