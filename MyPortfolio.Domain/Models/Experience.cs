using System;
using System.Collections.Generic;

namespace MyPortfolio.Domain.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string EntrepriseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Role { get; set; }
        public IEnumerable<Mission> Missions { get; set; }
    }
}
