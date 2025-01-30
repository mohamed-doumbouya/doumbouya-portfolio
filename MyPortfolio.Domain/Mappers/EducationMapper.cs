using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Models;
using System.Collections.Generic;

namespace MyPortfolio.Domain.Mappers
{
    public static class EducationMapper
    {

        public static EducationDto ConvertToEducationDTO(this Education education)
        {
            if (education == null)
            {
                return null;
            }

            var educationDto = new EducationDto();

            educationDto.Certification = education.Certification;
            educationDto.StartDate = education.StartDate;
            educationDto.EndDate = education.EndDate;
            educationDto.City = education.City ?? string.Empty;
            educationDto.Description = education.Description ?? string.Empty;
            educationDto.Country = education.Country ?? string.Empty;
            educationDto.Name = education.Name;
            educationDto.Id = education.Id;

            return educationDto;
        }

        public static IEnumerable<EducationDto> ConvertToEducationDtoList(this IEnumerable<Education> educations)
        {
            foreach (var Education in educations)
            {
                yield return ConvertToEducationDTO(Education);
            }
        }
    }
}
