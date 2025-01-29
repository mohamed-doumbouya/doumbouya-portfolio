using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Services;

namespace MyPortfolio.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServiceHandler _serviceHandler;

        public ServicesController(IServiceHandler serviceHandler)
        {
            _serviceHandler = serviceHandler;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Details(int Id)
        {
            ServiceDto? service = await _serviceHandler.GetServiceByAsync(Id);

            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }
    }
}
