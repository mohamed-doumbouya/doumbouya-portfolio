using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Domain.Models
{
    public class Experience
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string EntrepriseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Role { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        //Relation
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
        public IEnumerable<Mission> Missions { get; set; }
    }
}
