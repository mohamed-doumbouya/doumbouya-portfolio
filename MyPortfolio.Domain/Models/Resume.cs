using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MyPortfolio.Domain.Models
{
    public class Resume
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Summary { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        //Relation
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
    }
}
