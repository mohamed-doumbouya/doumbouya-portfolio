using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Models;
using System.Collections.Generic;

namespace MyPortfolio.Domain.Mappers
{
    public static class ExperienceMapper
    {

        public static ExperienceDto ConvertToExperienceDTO(this Experience experience)
        {
            if (experience == null)
            {
                return null;
            }

            var experienceDto = new ExperienceDto();

            experienceDto.EntrepriseName = experience.EntrepriseName;
            experienceDto.StartDate = experience.StartDate;
            experienceDto.EndDate = experience.EndDate;
            experienceDto.City = experience.City ?? string.Empty;
            experienceDto.Role = experience.Role ?? string.Empty;
            experienceDto.Country = experience.Country ?? string.Empty;
            experienceDto.Missions = experience.Missions.ConvertToMissionDtoList();

            return experienceDto;
        }

        public static IEnumerable<ExperienceDto> ConvertToExperienceDtoList(this IEnumerable<Experience> experiences)
        {
            foreach (var Experience in experiences)
            {
                yield return ConvertToExperienceDTO(Experience);
            }
        }
    }
}
