using System;
using System.Collections.Generic;

namespace MyPortfolio.Domain.DTO
{
    public class ExperienceDto
    {
        public string EntrepriseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Role { get; set; }
        public IEnumerable<MissionDto> Missions { get; set; }
    }
}
