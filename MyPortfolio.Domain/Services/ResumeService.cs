using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Services
{
    public class ResumeService : IResumeService
    {
        private readonly IEducationService _educationService;
        private readonly IExperienceService _experienceService;
        private readonly IResumeRepository _resumeRepository;

        public ResumeService
        (
            IEducationService educationService,
            IExperienceService experienceService,
            IResumeRepository resumeRepository
        )
        {
            _educationService = educationService;
            _experienceService = experienceService;
            _resumeRepository = resumeRepository;
        }

        public async Task<ResumeDto> GetResumeByUserIdAsync(string userId)
        {
            var userResume = await _resumeRepository.GetResumeByUserIdAsync(userId);
            var resume = new ResumeDto
            {
                Summary = userResume.Summary,
                Educations = await _educationService.GetUserEducations(),
                Experiences = await _experienceService.GetUserExperiences()
            };

            return resume;
        }
    }
}
