using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPortfolio.Domain.Models
{
    public class Testimonial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Author { get; set; }
        public string? AuthorProfession { get; set; }
        public string? AuthorImage { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }

        [Display(Name = "LinkedIn Profile")]
        [DataType(DataType.Url)]
        [StringLength(200)]
        public string? LinkedInUrl { get; set; }

        [Display(Name = "Portfolio/Website")]
        [DataType(DataType.Url)]
        [StringLength(200)]
        public string? PortfolioUrl { get; set; }

        [Display(Name = "GitHub Profile")]
        [DataType(DataType.Url)]
        [StringLength(200)]
        public string? GitHubUrl { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        //Relation
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
