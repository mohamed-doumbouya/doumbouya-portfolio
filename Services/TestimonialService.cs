using MyPortfolio.Models.DTO;
using MyPortfolio.Services.Interfaces;

namespace MyPortfolio.Services
{
    public class TestimonialService : ITestimonialService
    {
        public async Task<IEnumerable<TestimonialDTO>> GetUserTestimonials()
        {
            var testimonials = new List<TestimonialDTO>
                    {
                        new TestimonialDTO
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
