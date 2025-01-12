using MyPortfolio.Domain.Models.ViewModels;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<UserInfoViewModel> GetUserInformationsAsync();
    }
}
