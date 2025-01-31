using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Mappers;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Services
{
    public class UserService : IUserService
    {
        #region Fields
        private readonly ISkillService _skillService;
        private readonly IUserRepository _userRepository;
        #endregion Fields

        #region Constructor
        public UserService
        (
            ISkillService skillService,
            IUserRepository userRepository
        )
        {
            _skillService = skillService;
            _userRepository = userRepository;
        }


        #endregion Constructor

        #region IUserService implementation
        public async Task<UserDto> GetUserAsync()
        {
            var user = await _userRepository.GetUserAsync();
            var userDto = user.ConvertToUserDTO();
            userDto.Skills = await _skillService.GetSkillsByUserIdAsync("userId");
            return userDto;
        }
        #endregion IUserService
    }
}
