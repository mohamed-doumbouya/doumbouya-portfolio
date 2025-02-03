using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Models.ViewModels;
using MyPortfolio.Domain.Services;
using System.Net;
using System.Net.Mail;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly IEmailService _emailService;

        public ContactController(IEmailService emailService)
        {
            _emailService = emailService;
        }

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
                await _emailService.SendMailAsync(contact);

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
