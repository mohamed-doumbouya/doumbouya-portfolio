using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Services
{
    public class TestimonialService : ITestimonialService
    {
        public async Task<IEnumerable<TestimonialDto>> GetUserTestimonials()
        {
            var testimonials = new List<TestimonialDto>
                    {
                        new TestimonialDto
                        {
                            Author = "Jena Karlis",
                            AuthorImage = "~/images/testimonials/testimonials-2.jpg",
                            Content = "Enim nisi quem export duis labore cillum quae magna enim sint quorum nulla quem veniam duis minim tempor labore quem eram duis noster aute amet eram fore quis sint minim.",
                            AuthorProfession = "Store Owner"
                        }
                    };

            return await Task.FromResult(testimonials);
        }
    }
}
