using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Domain.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Client { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? ImageUrl { get; set; }
        public string? ProjectURL { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string? Summary { get; set; }

        //Relation
        public int CategoryId { get; set; }
        public ProjectCategory Category { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public IEnumerable<ProjectTechnology> ProjectTechnologies { get; set; }
    }
}
