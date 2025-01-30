using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Mappers;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Services
{
    public class ResumeService : IResumeService
    {
        private readonly IResumeRepository _resumeRepository;

        public ResumeService(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }

        public async Task<ResumeDto> GetResumeAsync()
        {
            var userResume = await _resumeRepository.GetResumeAsync();
            return userResume.ConvertToResumeDTO();
        }
    }
}
