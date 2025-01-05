using MyPortfolio.Models.DTO;

namespace MyPortfolio.Models
{
    public class ApplicationUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Degree { get; set; }
        public string City { get; set; }
        public DateTime Birthday { get; set; }
        public bool FreelanceAvailable { get; set; }
        public string Profession { get; set; }
        public string Summary { get; set; }
        public string ProfilImgUrl { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}
