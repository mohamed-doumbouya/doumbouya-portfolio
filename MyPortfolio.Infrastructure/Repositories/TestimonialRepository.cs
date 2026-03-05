using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Models;
using MyPortfolio.Infrastructure.Data;
using MyPortfolio.Infrastructure.Repositories.Generics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Infrastructure.Repositories
{
    public class TestimonialRepository : GenericRepository<Testimonial>, ITestimonialRepository
    {
        public TestimonialRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Testimonial>> GetUserTestimonialsAsync()
        {
            return await GetAllAsync();
        }
    }
}
