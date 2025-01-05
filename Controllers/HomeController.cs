using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MyPortfolio.Models.ViewModels;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UserInfoViewModel userInfo = new UserInfoViewModel
            {
                UserDTO = new Models.DTO.UserDTO
                {
                    FirstName = "Mohamed",
                    LastName = "DOUMBOUYA",
                    City = "Paris",
                    Country = "France",
                    Email = "mohamed.doumbouya1112@gmail.com",
                    Birthday = new DateTime(1994, 9, 16),
                    Degree = "Software Engineer",
                    Website = "www.example.com",
                    Phone = "+123 456 7890",
                    Profession = "Backend Developer",
                    Summary = "Summary Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore\r\nmagna aliqua.",
                    Freelance = "Available"
                }
            };

            
            var birthDate = userInfo.UserDTO.Birthday;
            userInfo.UserDTO.Age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-userInfo.UserDTO.Age))
            {
                userInfo.UserDTO.Age--;
            }

            return View(userInfo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
