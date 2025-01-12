using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Services
{
    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _skillRepository;

        public SkillService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public async Task<IEnumerable<SkillDto>> GetSkillsByUserIdAsync(string userId)
        {
            var userSkills = await _skillRepository.GetSkillsByUserIdAsync(userId);

            return userSkills.Select(skill => new SkillDto
            {
                Name = skill.Name,
                Percentage = skill.Percentage
            });
        }
    }
}
