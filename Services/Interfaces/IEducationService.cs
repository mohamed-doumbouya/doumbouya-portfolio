using MyPortfolio.Models.DTO;

namespace MyPortfolio
{
    public interface IEducationService
    {
        Task<IEnumerable<EducationDTO>> GetUserEducations();
    }
}