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
                    Degree = "Ingénieur Logiciel",
                    Website = "www.example.com",
                    Phone = "+123 456 7890",
                    Profession = "Ingénieur Logiciel",
                    Summary = "Summary Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore\r\nmagna aliqua.",
                    Freelance = "Disponible",
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
                        },
                        Experiences = new List<ExperienceDTO>
                        {
                            new ExperienceDTO
                            {
                                Role = "Developpeur FullStack (.NET - Ruby)",
                                EntrepriseName = "Akka Technology",
                                City = "Casablanca",
                                Country = "Maroc",
                                StartDate = new DateTime(2019, 1, 1),
                                EndDate = new DateTime(2022, 10, 06),
                                Missions = new List<MissionDTO>
                                {
                                    new MissionDTO
                                    {
                                        Description = "Lead in the design, development, and implementation of the graphic, layout, and production communication materials"
                                    },
                                    new MissionDTO
                                    {
                                        Description = "Delegate tasks to the 7 members of the design team and provide counsel on all aspects of the project"
                                    },
                                    new MissionDTO
                                    {
                                        Description = "Supervise the assessment of all graphic materials in order to ensure quality and accuracy of the design"
                                    },
                                    new MissionDTO
                                    {
                                        Description = "Oversee the efficient use of production project budgets ranging from $2,000 - $25,000"
                                    }
                                }
                            },
                            new ExperienceDTO
                            {
                                Role = "Consultant .NET/C#",
                                EntrepriseName = "Groupe BPCE",
                                City = "Paris",
                                Country = "France",
                                StartDate = new DateTime(2022, 1, 1),
                                EndDate = null,
                                Missions = new List<MissionDTO>
                                {
                                    new MissionDTO
                                    {
                                        Description = "Lead in the design, development, and implementation of the graphic, layout, and production communication materials"
                                    },
                                    new MissionDTO
                                    {
                                        Description = "Delegate tasks to the 7 members of the design team and provide counsel on all aspects of the project"
                                    },
                                    new MissionDTO
                                    {
                                        Description = "Supervise the assessment of all graphic materials in order to ensure quality and accuracy of the design"
                                    },
                                    new MissionDTO
                                    {
                                        Description = "Oversee the efficient use of production project budgets ranging from $2,000 - $25,000"
                                    }
                                }
                            }
                        }
                    },
                    Projects = new List<ProjectDTO>
                    {
                        new ProjectDTO
                        {
                            Category = "Web Design",
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/app-1.jpg",
                            Client = "ASU Company",
                            Title = "App 1",
                            Name = "Project information",
                            Description = "Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.",
                            Summary = "Lorem ipsum, dolor sit amet consectetur",
                            StartDate = new DateTime(2016, 01, 15)
                        },
                        new ProjectDTO
                        {
                            Category = "Web Design",
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/product-1.jpg",
                            Client = "ASU Company",
                            Title = "Product 1",
                            Name = "Project information",
                            Description = "Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.",
                            Summary = "Lorem ipsum, dolor sit amet consectetur",
                            StartDate = new DateTime(2016, 01, 15)
                        },
                        new ProjectDTO
                        {
                            Category = "Web Design",
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/branding-1.jpg",
                            Client = "ASU Company",
                            Title = "Branding 1",
                            Name = "Project information",
                            Description = "Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.",
                            Summary = "Lorem ipsum, dolor sit amet consectetur",
                            StartDate = new DateTime(2016, 01, 15)
                        },
                        new ProjectDTO
                        {
                            Category = "Web Design",
                            ProjectURL = "www.example.com",
                            ImageUrl = "~/images/portfolio/books-1.jpg",
                            Client = "ASU Company",
                            Title = "Books 1",
                            Name = "Books 1",
                            Description = "Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.",
                            Summary = "Lorem ipsum, dolor sit amet consectetur",
                            StartDate = new DateTime(2016, 01, 15)
                        }
                    },
                    Services = new List<ServiceDTO>
                    {
                        new ServiceDTO
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new ServiceDTO
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new ServiceDTO
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new ServiceDTO
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new ServiceDTO
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        }
                    },
                    Testimonials = new List<TestimonialDTO> 
                    { 
                        new TestimonialDTO
                        {
                            Author = "Jena Karlis",
                            AuthorImage = "~/images/testimonials/testimonials-2.jpg",
                            Content = "Enim nisi quem export duis labore cillum quae magna enim sint quorum nulla quem veniam duis minim tempor labore quem eram duis noster aute amet eram fore quis sint minim.",
                            AuthorProfession = "Store Owner"
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
