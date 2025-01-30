using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Models;
using System.Collections.Generic;


namespace MyPortfolio.Domain.Mappers
{
    public static class MissionMapper
    {

        public static MissionDto ConvertToMissionDTO(this Mission mission)
        {
            if (mission == null)
            {
                return null;
            }

            var missionDto = new MissionDto();

            missionDto.Description = mission.Description ?? string.Empty;

            return missionDto;
        }

        public static IEnumerable<MissionDto> ConvertToMissionDtoList(this IEnumerable<Mission> missions)
        {
            foreach (var Mission in missions)
            {
                yield return ConvertToMissionDTO(Mission);
            }
        }
    }
}
