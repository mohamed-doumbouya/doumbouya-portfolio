using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Models;
using MyPortfolio.Infrastructure.Data;
using MyPortfolio.Infrastructure.Repositories.Generics;
using System.Collections.Generic;
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
            var skills = new List<Skill>
                    {
                        new Skill
                        {
                            Name = "HTML",
                            Percentage = 100
                        },
                        new Skill
                        {
                            Name = "CSS",
                            Percentage = 90
                        },
                        new Skill
                        {
                            Name = "JavaScript",
                            Percentage = 75
                        }
            };

            return await Task.FromResult(skills);
        }
    }
}
