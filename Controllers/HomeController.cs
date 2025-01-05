using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MyPortfolio.Models.DTO;
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
                UserDTO = new UserDTO
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
                    Freelance = "Available",
                    Skills = new List<SkillDTO>
                    {
                        new SkillDTO
                        {
                            Name = "HTML",
                            Percentage = 100
                        },
                        new SkillDTO
                        {
                            Name = "CSS",
                            Percentage = 90
                        },
                        new SkillDTO
                        {
                            Name = "JavaScript",
                            Percentage = 75
                        }
                    },
                    Resume = new ResumeDTO
                    {
                        Summary = "Innovative and deadline-driven Graphic Designer with 3+ years of experience designing and developing user-centered digital/print marketing material from initial concept to final, polished deliverable.",
                        Educations = new List<EducationDTO>
                        {
                           new EducationDTO
                           {
                               Description = "Qui deserunt veniam. Et sed aliquam labore tempore sed quisquam iusto autem sit. Ea vero voluptatum qui ut dignissimos deleniti nerada porti sand markend",
                               Name = "Sainte Marie",
                               City = "Conakry",
                               Country = "Guinea",
                               Certification = "Baccalaureat Unique",
                               StartDate = new DateTime(2011, 9, 1),
                               EndDate = new DateTime(2014, 10, 1)
                           },
                           new EducationDTO
                           {
                               Description = "Qui deserunt veniam. Et sed aliquam labore tempore sed quisquam iusto autem sit. Ea vero voluptatum qui ut dignissimos deleniti nerada porti sand markend",
                               Name = "Faculté des Sciences et Techniques (FST)",
                               City = "Errachidia",
                               Country = "Maroc",
                               Certification = "Diplôme des Etudes Universitaires en Science et Technique (DEUST)",
                               StartDate = new DateTime(2014, 11, 2),
                               EndDate = new DateTime(2016, 10, 1)
                           },
                           new EducationDTO
                           {
                               Description = "Qui deserunt veniam. Et sed aliquam labore tempore sed quisquam iusto autem sit. Ea vero voluptatum qui ut dignissimos deleniti nerada porti sand markend",
                               Name = "Ingénierie Logiciel et Système d'Information",
                               City = "Rabat",
                               Country = "Maroc",
                               Certification = "Diplôme des études universitaires en science et technique (DEUST)",
                               StartDate = new DateTime(2016, 11, 2),
                               EndDate = new DateTime(2019, 06, 1)
                           }
                        }
                    }
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
