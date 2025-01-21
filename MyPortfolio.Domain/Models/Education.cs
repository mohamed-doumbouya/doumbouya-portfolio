using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Domain.Models
{
    public class Education
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Certification { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }


        //Relation
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
