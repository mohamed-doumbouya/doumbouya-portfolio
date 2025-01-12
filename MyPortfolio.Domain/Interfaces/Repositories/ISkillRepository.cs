using MyPortfolio.Domain.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Repositories
{
    public interface ISkillRepository
    {
        Task<IEnumerable<Skill>> GetSkillsByUserIdAsync(string userId);
    }
}
