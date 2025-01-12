using MyPortfolio.Domain.DTO;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Services
{
    public interface IResumeService
    {
        Task<ResumeDto> GetResumeByUserIdAsync(string userId);
    }
}