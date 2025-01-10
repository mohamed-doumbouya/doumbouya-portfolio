using MyPortfolio.Models.DTO;

namespace MyPortfolio
{
    public interface IExperienceService
    {
        Task<IEnumerable<ExperienceDTO>> GetUserExperiences();
    }
}