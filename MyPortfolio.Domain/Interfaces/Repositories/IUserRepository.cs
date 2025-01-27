using MyPortfolio.Domain.Models;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<ApplicationUser?> GetUserByEmailAsync(string email);
    }
}
