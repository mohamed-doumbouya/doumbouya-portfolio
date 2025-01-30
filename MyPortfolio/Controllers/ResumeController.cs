using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Models.ViewModels;

namespace MyPortfolio.Controllers
{
    public class ResumeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IResumeService _resumeService;

        public ResumeController(IUserService userService, IResumeService resumeService)
        {
            _userService = userService;
            _resumeService = resumeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Details()
        {
            var user = await _userService.GetUserAsync();
            if(user == null)
            {
                return NotFound();
            }

            var resumeDetails = new ResumeDetailsViewModel
            {
                UserDTO = user,
                ResumeDTO = await _resumeService.GetResumeAsync()
            };

            return View(resumeDetails);
        }
    }
}
