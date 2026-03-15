using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Models.ViewModels;
using Rotativa.AspNetCore;
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
                return NotFound();

            var filePath = Path.Combine(Path.GetTempPath(), $"resume_{user.LastName.ToLower()}.pdf");
            if (!System.IO.File.Exists(filePath))
            {
                var resume = await _resumeService.GetResumeAsync().ConfigureAwait(false);

                var vm = new ResumeDetailsViewModel
                {
                    UserDTO = user,
                    ResumeDTO = resume
                };

                var pdf = new ViewAsPdf("ResumePdf", vm)
                {
                    PageSize = Size.A4
                };

                var bytes = await pdf.BuildFile(ControllerContext);

                await System.IO.File.WriteAllBytesAsync(filePath, bytes);
            }

            return PhysicalFile(filePath, "application/pdf", $"resume_{user.LastName.ToLower()}.pdf");
        }
    }
}
