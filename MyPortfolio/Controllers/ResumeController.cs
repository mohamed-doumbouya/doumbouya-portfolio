using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Models.ViewModels;
using Rotativa.AspNetCore;
using Rotativa.AspNetCore.Options;
using Size = Rotativa.AspNetCore.Options.Size;

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
            if (user == null)
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

        public async Task<IActionResult> DownloadPdf()
        {
            var user = await _userService.GetUserAsync();
            if (user == null)
            {
                return NotFound();
            }

            var resume = await _resumeService.GetResumeAsync();

            var vm = new ResumeDetailsViewModel { UserDTO = user, ResumeDTO = resume };

            return new ViewAsPdf("ResumePdf", vm)
            {
                FileName = $"resume_{user.LastName}.pdf",
                PageSize = Size.A4,
                PageMargins = new Margins(10, 15, 10, 15)
            };
        }
    }
}
