namespace MyPortfolio.Domain.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relation
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }
    }
}
