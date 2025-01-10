namespace MyPortfolio.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string AuthorProfession { get; set; }
        public string AuthorImage { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
    }
}
