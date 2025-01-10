using MyPortfolio.Models.DTO;

namespace MyPortfolio.Services
{
    public class ResumeService : IResumeService
    {
        private readonly IEducationService _educationService;
        private readonly IExperienceService _experienceService;

        public ResumeService
        (
            IEducationService educationService,
            IExperienceService experienceService
        )
        {
            _educationService = educationService;
            _experienceService = experienceService;
        }

        public async Task<ResumeDTO> GetUserResumeAsync()
        {
            var resume = new ResumeDTO
            {
                Summary = "Innovative and deadline-driven Graphic Designer with 3+ years of experience designing and developing user-centered digital/print marketing material from initial concept to final, polished deliverable.",
                Educations = await _educationService.GetUserEducations(),
                Experiences = await _experienceService.GetUserExperiences()
            };

            return resume;
        }
    }
}
