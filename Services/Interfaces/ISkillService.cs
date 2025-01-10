using MyPortfolio.Models.DTO;

namespace MyPortfolio.Services.Interfaces
{
    public interface ISkillService
    {
        Task<IEnumerable<SkillDTO>> GetUserSkillsAsync();
    }
}
