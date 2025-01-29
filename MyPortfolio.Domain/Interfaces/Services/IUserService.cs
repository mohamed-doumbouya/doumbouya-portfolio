using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Models.ViewModels;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<UserDto> GetUserAsync();
        Task<UserInfoViewModel> GetUserInformationsAsync();
    }
}
