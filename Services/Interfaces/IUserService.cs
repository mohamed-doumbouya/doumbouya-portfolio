using MyPortfolio.Models.ViewModels;

namespace MyPortfolio.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserInfoViewModel> GetUserInformationsAsync();
    }
}
