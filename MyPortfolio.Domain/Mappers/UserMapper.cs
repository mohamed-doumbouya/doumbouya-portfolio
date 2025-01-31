using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Models;
using System;
using System.Linq;

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

            var userDto = new UserDto();

            var adress = user.Adresses.FirstOrDefault(a => a.IsActive);

            userDto.FirstName = user.FirstName;
            userDto.LastName = user.LastName;
            userDto.Website = user.Website ?? string.Empty;
            userDto.Email = user.Email ?? string.Empty;
            userDto.Degree = user.Degree ?? string.Empty;
            userDto.Birthday = user.Birthday;
            userDto.Phone = user.PhoneNumber ?? string.Empty;
            userDto.Profession = user.Profession ?? string.Empty;
            userDto.Summary = user.Summary ?? string.Empty;
            userDto.Freelance = user.FreelanceAvailable ? "Disponible" : "Indisponible";
            userDto.Adress = new AddressDto
            {
                City = adress?.City ?? string.Empty,
                Country = adress?.Country ?? string.Empty
            };

            var birthDate = userDto.Birthday;
            userDto.Age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-userDto.Age))
            {
                userDto.Age--;
            }

            return userDto;
        }
    }
}
