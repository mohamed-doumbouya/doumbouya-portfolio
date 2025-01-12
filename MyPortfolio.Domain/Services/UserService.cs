using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Models.ViewModels;
using System;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Services
{
    public class UserService : IUserService
    {
        #region Fields
        private readonly ISkillService _skillService;
        private readonly IResumeService _resumeService;
        private readonly IProjectService _projectService;
        private readonly IServiceHandler _serviceHandler;
        private readonly ITestimonialService _testimonialService;
        #endregion Fields

        #region Constructor
        public UserService
        (
            ISkillService skillService,
            IResumeService resumeService,
            IProjectService projectService,
            IServiceHandler serviceHandler,
            ITestimonialService testimonialService
        )
        {
            _skillService = skillService;
            _resumeService = resumeService;
            _projectService = projectService;
            _serviceHandler = serviceHandler;
            _testimonialService = testimonialService;
        }
        #endregion Constructor

        #region IUserService implementation
        public async Task<UserInfoViewModel> GetUserInformationsAsync()
        {
            var userInfo = new UserInfoViewModel
            {
                UserDTO = new UserDto
                {
                    FirstName = "Mohamed",
                    LastName = "Doumbouya",
                    City = "Paris",
                    Country = "France",
                    Email = "test.test@gmail.com",
                    Birthday = new DateTime(1999, 9, 16),
                    Degree = "Ingénieur Logiciel",
                    Website = "www.example.com",
                    Phone = "+123 456 7890",
                    Profession = "Ingénieur Logiciel",
                    Summary = "Summary Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore\r\nmagna aliqua.",
                    Freelance = "Disponible",
                    Skills = await _skillService.GetUserSkillsAsync(),
                    Resume = await _resumeService.GetUserResumeAsync(),
                    Projects = await _projectService.GetUserProjectsAsync(),
                    Services = await _serviceHandler.GetUserServicesAsync(),
                    Testimonials = await _testimonialService.GetUserTestimonials()
                }
            };

            var birthDate = userInfo.UserDTO.Birthday;
            userInfo.UserDTO.Age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-userInfo.UserDTO.Age))
            {
                userInfo.UserDTO.Age--;
            }

            return userInfo;
        }
        #endregion IUserService
    }
}
