using MyPortfolio.Models.DTO;
using MyPortfolio.Services.Interfaces;

namespace MyPortfolio.Services
{
    public class SkillService : ISkillService
    {
        public async Task<IEnumerable<SkillDTO>> GetUserSkillsAsync()
        {
            var skills = new List<SkillDTO>
                    {
                        new SkillDTO
                        {
                            Name = "HTML",
                            Percentage = 100
                        },
                        new SkillDTO
                        {
                            Name = "CSS",
                            Percentage = 90
                        },
                        new SkillDTO
                        {
                            Name = "JavaScript",
                            Percentage = 75
                        }
            };

            return await Task.FromResult(skills);
        }
    }
}
