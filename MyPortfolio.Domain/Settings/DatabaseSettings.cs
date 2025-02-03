using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Domain.Settings
{
    public class DatabaseSettings
    {
        public static readonly string DatabaseSection = "ConnectionStrings";

        [Required]
        public string DefaultConnection { get; set; }
    }
}
