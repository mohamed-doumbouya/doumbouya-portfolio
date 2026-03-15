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
            userDto.Phone = user.PhoneNumber ?? string.Empty;
            userDto.Profession = user.Profession ?? string.Empty;
            userDto.Summary = user.Summary ?? string.Empty;
            userDto.Freelance = user.FreelanceAvailable ? "Available" : "Unavailable";
            userDto.Adress = new AddressDto
            {
                City = adress?.City ?? string.Empty,
                Country = adress?.Country ?? string.Empty
            };

            var birthDate = userDto.Birthday;
            if (birthDate.HasValue)
            {
                userDto.Age = DateTime.Now.Year - birthDate.Value.Year;
                if (birthDate > DateTime.Now.AddYears(-userDto.Age.Value))
                {
                    userDto.Age--;
                }
            }

            return userDto;
        }
    }
}
