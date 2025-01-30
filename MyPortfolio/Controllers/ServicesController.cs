using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Models.ViewModels;

namespace MyPortfolio.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServiceHandler _serviceHandler;
        private readonly ITestimonialService _testimonialService;

        public ServicesController(IServiceHandler serviceHandler, ITestimonialService testimonialService)
        {
            _serviceHandler = serviceHandler;
            _testimonialService = testimonialService;
        }

        public async Task<IActionResult> Index()
        {
            var serviceViewModel = new ServiceViewModel();

            serviceViewModel.Services = await _serviceHandler.GetServicesAsync();
            serviceViewModel.Testimonials = await _testimonialService.GetUserTestimonials();
            return View(serviceViewModel);
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
