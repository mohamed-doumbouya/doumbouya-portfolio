using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Services
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialService(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public async Task<IEnumerable<TestimonialDto>> GetUserTestimonials()
        {
            var testimonials = await _testimonialRepository.GetUserTestimonialsAsync();

            return testimonials.Select(t => new TestimonialDto
            {
                Id = t.Id,
                Author = t.Author,
                AuthorProfession = t.AuthorProfession ?? string.Empty,
                AuthorImage = t.AuthorImage ?? string.Empty,
                Content = t.Content,
                Rating = t.Rating
            });
        }
    }
}
