using MyPortfolio.Models.DTO;

namespace MyPortfolio
{
    public interface IResumeService
    {
        Task<ResumeDTO> GetUserResumeAsync();
    }
}