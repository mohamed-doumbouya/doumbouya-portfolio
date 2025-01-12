using MyPortfolio.Domain.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Services
{
    public interface ISkillService
    {
        Task<IEnumerable<SkillDto>> GetSkillsByUserIdAsync(string userId);
    }
}
