using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Models.ViewModels;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly IEmailService _emailService;
        private readonly ILogger<ContactController> _logger;
        private readonly IValidator<ContactViewModel> _validator;
        public ContactController(
            IEmailService emailService,
            ILogger<ContactController> logger,
            IValidator<ContactViewModel> validator)
        {
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new ContactViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactViewModel contact)
        {
            ValidationResult validationResult = await _validator.ValidateAsync(contact);

            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }

                _logger.LogWarning("Contact form validation failed: {Errors}",
                    string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage)));

                return View(contact);
            }

            try
            {
                _logger.LogInformation("Attempting to send email from {Email}", contact.SenderEmailAdress);

                await _emailService.SendMailAsync(contact);

                _logger.LogInformation("Email sent successfully to {Email}", contact.SenderEmailAdress);

                TempData["SuccessMessage"] = "Your message has been sent. Thank you!";
                return RedirectToAction("Confirmation");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending email from {Email}", contact.SenderEmailAdress);

                ModelState.AddModelError("", "An error has occurred while sending the message. Please try again later.");
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