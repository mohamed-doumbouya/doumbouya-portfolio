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
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
    }
}
