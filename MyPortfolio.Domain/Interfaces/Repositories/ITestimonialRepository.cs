using MyPortfolio.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Repositories
{
    public interface ITestimonialRepository
    {
        Task<IEnumerable<Testimonial>> GetUserTestimonialsAsync();
    }
}
