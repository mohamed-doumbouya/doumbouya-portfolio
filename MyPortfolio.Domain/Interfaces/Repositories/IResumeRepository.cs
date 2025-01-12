using MyPortfolio.Domain.Models;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Repositories
{
    public interface IResumeRepository
    {
        Task<Resume> GetResumeByUserIdAsync(string userId);
    }
}
