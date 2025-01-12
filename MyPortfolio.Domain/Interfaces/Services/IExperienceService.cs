using MyPortfolio.Domain.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Services
{
    public interface IExperienceService
    {
        Task<IEnumerable<ExperienceDto>> GetUserExperiences();
    }
}