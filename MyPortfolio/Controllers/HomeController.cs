using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Models.ViewModels;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(IUserService userService, ILogger<HomeController> logger)
        {
            _logger = logger;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Get user informations ...");
            UserInfoViewModel userInfo = new UserInfoViewModel();
            userInfo.UserDTO = await _userService.GetUserAsync();

            return View(userInfo);
        }
    }
}
