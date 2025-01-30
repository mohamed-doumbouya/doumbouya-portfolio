using MyPortfolio.Domain.DTO;
using System.Collections.Generic;

namespace MyPortfolio.Domain.Models.ViewModels
{
    public class ServiceViewModel
    {
        public IEnumerable<ServiceDto> Services { get; set; }
        public IEnumerable<TestimonialDto> Testimonials { get; set; }
    }
}
