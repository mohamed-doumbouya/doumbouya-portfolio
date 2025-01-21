namespace MyPortfolio.Domain.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //Relation
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
