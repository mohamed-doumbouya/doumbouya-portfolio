namespace MyPortfolio.Domain.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
        public SkillCategory Category { get; set; }

        //Relation
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
