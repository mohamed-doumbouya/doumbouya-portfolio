namespace MyPortfolio.Models.DTO
{
    public class ResumeDTO
    {
        public string Summary { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
    }
}
