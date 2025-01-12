using System.Collections.Generic;

namespace MyPortfolio.Domain.DTO
{
    public class ResumeDto
    {
        public string Summary { get; set; }
        public IEnumerable<EducationDto> Educations { get; set; }
        public IEnumerable<ExperienceDto> Experiences { get; set; }
    }
}
