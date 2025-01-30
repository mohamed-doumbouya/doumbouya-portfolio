using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Domain.Models.ViewModels;
using System.Net;
using System.Net.Mail;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactViewModel contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }

            try
            {
                var smtpClient = new SmtpClient("smtp.example.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(contact.SenderEmailAdress, "tonmotdepasse"),
                    EnableSsl = true
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(contact.SenderEmailAdress),
                    Subject = contact.Subject,
                    Body = $"Sender name : {contact.SenderName}\nEmail : {contact.SenderEmailAdress}\nMessage :\n{contact.Message}",
                    IsBodyHtml = false
                };

                mailMessage.To.Add("mohamed.doumbouya1112@gmail.com");

                await smtpClient.SendMailAsync(mailMessage);

                return RedirectToAction("Confirmation");
            }
            catch
            {
                ModelState.AddModelError("", "An error has occurred while sending the message.");
                return View(contact);
            }
        }

        [HttpGet]
        public IActionResult Confirmation()
        {
            return View();
        }
    }
}
