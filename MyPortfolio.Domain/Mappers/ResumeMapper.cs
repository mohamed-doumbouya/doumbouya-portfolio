using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Models;

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
            resumeDTO.Experiences = resume.Experiences.ConvertToExperienceDtoList();
            resumeDTO.Educations = resume.Educations.ConvertToEducationDtoList();

            return resumeDTO;
        }
    }
}
