using Microsoft.Extensions.Options;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Models.ViewModels;
using MyPortfolio.Domain.Settings;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

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
                From = new MailAddress(_smptSettings.Username, "Portfolio Website"),
                Subject = $"New Contact Message from {contact.SenderName}",
                Body = $@"
                    <h3>New Contact Message</h3>
                    <p><strong>Name:</strong> {contact.SenderName}</p>
                    <p><strong>Email:</strong> {contact.SenderEmailAdress}</p>
                    <p><strong>Subject:</strong> {contact.Subject}</p>
                    <hr/>
                    <p>{contact.Message}</p>
                ",
                IsBodyHtml = true
            };

            mailMessage.To.Add("integredoumbouya@gmail.com");
            mailMessage.ReplyToList.Add(new MailAddress(contact.SenderEmailAdress));

            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}