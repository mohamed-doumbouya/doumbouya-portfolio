using MyPortfolio.Models.DTO;

namespace MyPortfolio.Services.Interfaces
{
    public interface ITestimonialService
    {
        Task<IEnumerable<TestimonialDTO>> GetUserTestimonials();
    }
}
