using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace MyPortfolio.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Website { get; set; }
        public string? Degree { get; set; }
        public DateTime Birthday { get; set; }
        public bool FreelanceAvailable { get; set; }
        public string? Profession { get; set; }
        public string? Summary { get; set; }
        public string? ProfilImgUrl { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        // Relation
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Address> Adresses { get; set; }
        public Resume Resume { get; set; }
    }
}
