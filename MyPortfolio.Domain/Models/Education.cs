using System;

namespace MyPortfolio.Domain.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Certification { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }

        //Relation
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
