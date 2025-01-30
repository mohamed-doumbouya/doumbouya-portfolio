using Microsoft.AspNetCore.Identity;
using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Mappers;
using MyPortfolio.Domain.Models;
using MyPortfolio.Domain.Models.ViewModels;
using System;
using System.Linq;
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
        private readonly UserManager<ApplicationUser> _userManager;
        #endregion Fields

        #region Constructor
        public UserService
        (
            ISkillService skillService,
            IResumeService resumeService,
            IProjectService projectService,
            IServiceHandler serviceHandler,
            ITestimonialService testimonialService,
            IUserRepository userRepository,
            UserManager<ApplicationUser> userManager
        )
        {
            _skillService = skillService;
            _resumeService = resumeService;
            _projectService = projectService;
            _serviceHandler = serviceHandler;
            _testimonialService = testimonialService;
            _userRepository = userRepository;
            _userManager = userManager;
        }

        public async Task<UserDto> GetUserAsync()
        {
            var user = await _userManager.FindByEmailAsync("test.test@gmail.com");
            var userDto = user.ConvertToUserDTO();
            userDto.Skills = await _skillService.GetSkillsByUserIdAsync("userId");
            return userDto;
        }
        #endregion Constructor

        #region IUserService implementation
        public async Task<UserInfoViewModel> GetUserInformationsAsync()
        {

            var user = await _userRepository.GetUserByEmailAsync("test.test@gmail.com");

            if(user != null)
            {
                var adress = user.Adresses.FirstOrDefault(a => a.IsActive);
                var userInfo = new UserInfoViewModel();
                userInfo.UserDTO = new UserDto
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Adress = new AddressDto 
                    { 
                        City = adress?.City ?? string.Empty,
                        Country = adress?.Country ?? string.Empty
                    },
                    Email = user.Email,
                    Birthday = user.Birthday,
                    Degree = user.Degree ?? string.Empty,
                    Website = user.Website ?? string.Empty,
                    Phone = user.PhoneNumber ?? string.Empty,
                    Profession = user.Profession ?? string.Empty,
                    Summary = user.Summary ?? string.Empty,
                    Freelance = user.FreelanceAvailable ? "Disponible" : "Indisponible",
                    Skills = await _skillService.GetSkillsByUserIdAsync("userId"),
                    Resume = await _resumeService.GetResumeAsync(),
                    Projects = await _projectService.GetProjectsAsync(),
                    Services = await _serviceHandler.GetServicesAsync(),
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
