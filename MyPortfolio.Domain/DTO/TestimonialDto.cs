namespace MyPortfolio.Domain.DTO
{
    public class TestimonialDto
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string AuthorProfession { get; set; }
        public string AuthorImage { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? GitHubUrl { get; set; }
        public string? PortfolioUrl { get; set; }
    }
}
