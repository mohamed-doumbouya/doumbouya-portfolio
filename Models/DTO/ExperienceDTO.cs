namespace MyPortfolio.Models.DTO
{
    public class ExperienceDTO
    {
        public string EntrepriseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Role { get; set; }
        public IEnumerable<MissionDTO> Missions { get; set; }
    }
}
