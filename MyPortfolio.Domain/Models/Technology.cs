using System.Collections.Generic;

namespace MyPortfolio.Domain.Models
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relation
        public ICollection<ProjectTechnology> ProjectTechnologies { get; set; }
    }
}
