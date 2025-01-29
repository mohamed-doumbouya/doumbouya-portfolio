using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Services;

namespace MyPortfolio.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Details()
        {
            UserDto user = await _userService.GetUserAsync();
            return View(user);
        }
    }
}
