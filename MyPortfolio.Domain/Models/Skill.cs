using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MyPortfolio.Domain.Models
{
    public class Skill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        //Relation
        public int CategoryId { get; set; }
        public SkillCategory Category { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
