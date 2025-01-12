using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Repositories;
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
        private readonly IUserRepository _userRepository;
        #endregion Fields

        #region Constructor
        public UserService
        (
            ISkillService skillService,
            IResumeService resumeService,
            IProjectService projectService,
            IServiceHandler serviceHandler,
            ITestimonialService testimonialService,
            IUserRepository userRepository
        )
        {
            _skillService = skillService;
            _resumeService = resumeService;
            _projectService = projectService;
            _serviceHandler = serviceHandler;
            _testimonialService = testimonialService;
            _userRepository = userRepository;
        }
        #endregion Constructor

        #region IUserService implementation
        public async Task<UserInfoViewModel> GetUserInformationsAsync()
        {

            var user = await _userRepository.GetUserByEmailAsync("test.test@gmail.com");

            if(user != null)
            {
                var userInfo = new UserInfoViewModel();
                userInfo.UserDTO = new UserDto
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    City = user.City,
                    Country = user.Country,
                    Email = user.Email,
                    Birthday = user.Birthday,
                    Degree = user.Degree,
                    Website = user.Website,
                    Phone = user.Phone,
                    Profession = user.Profession,
                    Summary = user.Summary,
                    Freelance = user.FreelanceAvailable ? "Disponible" : "Indisponible",
                    Skills = await _skillService.GetSkillsByUserIdAsync("userId"),
                    Resume = await _resumeService.GetResumeByUserIdAsync("userId"),
                    Projects = await _projectService.GetUserProjectsAsync(),
                    Services = await _serviceHandler.GetUserServicesAsync(),
                    Testimonials = await _testimonialService.GetUserTestimonials()
                };

                var birthDate = userInfo.UserDTO.Birthday;
                userInfo.UserDTO.Age = DateTime.Now.Year - birthDate.Year;
                if (birthDate > DateTime.Now.AddYears(-userInfo.UserDTO.Age))
                {
                    userInfo.UserDTO.Age--;
                }

                return userInfo;
            }

            throw new InvalidCastException("User not found");
        }
        #endregion IUserService
    }
}
