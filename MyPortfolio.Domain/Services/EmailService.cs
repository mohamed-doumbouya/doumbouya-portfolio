using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Models.ViewModels;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MyPortfolio.Domain.Settings;

namespace MyPortfolio.Domain.Services
{
    public class EmailService : IEmailService
    {
        private readonly SmtpSettings _smptSettings;

        public EmailService(IOptions<SmtpSettings> smptSettings)
        {
            _smptSettings = smptSettings.Value;
        }

        public async Task SendMailAsync(ContactViewModel contact)
        {
            var smtpClient = new SmtpClient(_smptSettings.Server)
            {
                Port = _smptSettings.Port,
                Credentials = new NetworkCredential(_smptSettings.Username, _smptSettings.Password),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(contact.SenderEmailAdress),
                Subject = contact.Subject,
                Body = $"Sender name : {contact.SenderName}\nEmail : {contact.SenderEmailAdress}\nMessage :\n{contact.Message}",
                IsBodyHtml = false
            };

            mailMessage.To.Add(_smptSettings.Username);

            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}