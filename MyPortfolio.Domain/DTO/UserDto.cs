using System;
using System.Collections.Generic;

namespace MyPortfolio.Domain.DTO
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Degree { get; set; }
        public string City { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public string Freelance { get; set; }
        public string Profession { get; set; }
        public string Summary { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }

        // Relation
        public IEnumerable<SkillDto> Skills { get; set; }
        public IEnumerable<ProjectDto> Projects { get; set; }
        public IEnumerable<ServiceDto> Services { get; set; }
        public IEnumerable<TestimonialDto> Testimonials { get; set; }
        public ResumeDto Resume { get; set; }
    }
}
