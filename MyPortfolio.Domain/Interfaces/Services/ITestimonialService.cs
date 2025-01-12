using MyPortfolio.Domain.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Services
{
    public interface ITestimonialService
    {
        Task<IEnumerable<TestimonialDto>> GetUserTestimonials();
    }
}
