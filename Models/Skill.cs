namespace MyPortfolio.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public int Percentage { get; set; }
        public SkillCategory Category { get; set; }
    }
}
