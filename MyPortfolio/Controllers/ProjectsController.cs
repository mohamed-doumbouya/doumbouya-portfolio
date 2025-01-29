using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Services;

namespace MyPortfolio.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Details(int Id)
        {
           ProjectDto? project = await _projectService.GetProjectByIdAsync(Id);
           if(project == null)
            {
                return NotFound();
            }

            return View(project);
        }
    }
}
