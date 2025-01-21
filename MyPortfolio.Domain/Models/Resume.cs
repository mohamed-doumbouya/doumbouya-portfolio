using System.Collections.Generic;

namespace MyPortfolio.Domain.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string Summary { get; set; }

        //Relation
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<Experience> Experiences { get; set; }
    }
}
