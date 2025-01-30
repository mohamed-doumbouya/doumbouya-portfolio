using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Models;
using System.Linq;

namespace MyPortfolio.Domain.Mappers
{
    public static class ResumeMapper
    {

        public static ResumeDto ConvertToResumeDTO(this Resume resume)
        {
            if (resume == null)
            {
                return null;
            }

            var resumeDTO = new ResumeDto();

            resumeDTO.Summary = resume.Summary ?? string.Empty;
            resumeDTO.Experiences = resume.Experiences.OrderByDescending(e => e.StartDate).Take(2).ConvertToExperienceDtoList();
            resumeDTO.Educations = resume.Educations.OrderByDescending(e => e.StartDate).Take(3).ConvertToEducationDtoList();

            return resumeDTO;
        }
    }
}
