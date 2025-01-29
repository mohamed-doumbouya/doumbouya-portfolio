using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Models;

namespace MyPortfolio.Domain.Mappers
{
    public static class UserMapper
    {

        public static UserDto ConvertToUserDTO(this ApplicationUser? user)
        {
            if (user == null)
            {
                return null;
            }

            var UserDto = new UserDto();

            UserDto.FirstName = user.FirstName;
            UserDto.LastName = user.LastName;
            UserDto.Website = user.Website ?? string.Empty;
            UserDto.Email = user.Email ?? string.Empty;
            UserDto.Degree = user.Degree ?? string.Empty;
            UserDto.Birthday = user.Birthday;
            UserDto.Phone = user.PhoneNumber ?? string.Empty;
            UserDto.Profession = user.Profession ?? string.Empty;
            UserDto.Summary = user.Summary ?? string.Empty;
            UserDto.Freelance = user.FreelanceAvailable ? "Disponible" : "Indisponible";

            return UserDto;
        }
    }
}
