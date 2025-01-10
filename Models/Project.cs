using MyPortfolio.Models.DTO;

namespace MyPortfolio.Models
{
    public class Project
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ImageUrl { get; set; }
        public string ProjectURL { get; set; }
        public ProjectCategory Category { get; set; }
        public IEnumerable<TechnologyDTO> Technologies { get; set; }
    }
}
