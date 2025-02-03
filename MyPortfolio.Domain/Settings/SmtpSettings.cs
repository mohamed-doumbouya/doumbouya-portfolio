using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Domain.Settings
{
    public class SmtpSettings
    {
        public static readonly string SmtpSection = "SmtpSettings";

        [Required]
        public string Server { get; set; }

        [Range(1, 65535)]
        public int Port { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
