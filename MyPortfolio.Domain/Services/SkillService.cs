using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Services
{
    public class SkillService : ISkillService
    {
        public async Task<IEnumerable<SkillDto>> GetUserSkillsAsync()
        {
            var skills = new List<SkillDto>
                    {
                        new SkillDto
                        {
                            Name = "HTML",
                            Percentage = 100
                        },
                        new SkillDto
                        {
                            Name = "CSS",
                            Percentage = 90
                        },
                        new SkillDto
                        {
                            Name = "JavaScript",
                            Percentage = 75
                        }
            };

            return await Task.FromResult(skills);
        }
    }
}
