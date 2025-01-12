using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Models;
using System.Threading.Tasks;

namespace MyPortfolio.Infrastructure.Repositories
{
    public class ResumeRepository : IResumeRepository
    {
        public async Task<Resume> GetResumeByUserIdAsync(string userId)
        {
           var resume = new Resume();
            resume.Summary = "Innovative and deadline-driven Graphic Designer with 3+ years of experience designing and developing user-centered digital/print marketing material from initial concept to final, polished deliverable.";

            return await Task.FromResult(resume);
        }
    }
}
