using FluentValidation;
using MyPortfolio.Domain.Models.ViewModels;
using System;
using System.Text.RegularExpressions;

namespace MyPortfolio.Domain.Validators
{
    public class ContactViewModelValidator : AbstractValidator<ContactViewModel>
    {
        public ContactViewModelValidator()
        {
            RuleFor(x => x.SenderName)
                .NotEmpty().WithMessage("Please enter your name.")
                .Length(2, 100).WithMessage("Name must be between 2 and 100 characters.")
                .Matches(@"^[a-zA-ZÀ-ÿ\s\-']+$").WithMessage("Name contains invalid characters.")
                .Must(name => !ContainsDangerousContent(name)).WithMessage("Invalid characters detected.");

            RuleFor(x => x.SenderEmailAdress)
                .NotEmpty().WithMessage("Please enter your email address.")
                .EmailAddress().WithMessage("Please enter a valid email address.")
                .MaximumLength(100).WithMessage("Email is too long.")
                .Must(email => !ContainsDangerousContent(email)).WithMessage("Invalid characters detected.");

            RuleFor(x => x.Subject)
                .NotEmpty().WithMessage("Please enter a subject.")
                .Length(3, 200).WithMessage("Subject must be between 3 and 200 characters.")
                .Must(subject => !ContainsDangerousContent(subject)).WithMessage("Invalid characters detected.");

            RuleFor(x => x.Message)
                .NotEmpty().WithMessage("Please enter your message.")
                .Length(10, 5000).WithMessage("Message must be between 10 and 5000 characters.")
                .Must(message => !ContainsDangerousContent(message)).WithMessage("Message contains potentially harmful content.")
                .Must(message => !ContainsUrls(message) || AllowUrls).WithMessage("URLs are not allowed in messages.")
                .Must(message => !ContainsEmailAddresses(message)).WithMessage("Email addresses cannot be included in messages.");
        }

        private static bool ContainsDangerousContent(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;

            var dangerousPatterns = new[]
            {
                @"<script",
                @"javascript:",
                @"onclick=",
                @"onerror=",
                @"onload=",
                @"eval\(",
                @"document\.cookie",
                @"window\.location",
                @"<iframe",
                @"<embed",
                @"<object",
                @"vbscript:",
                @"data:text/html",
                @"base64",
                @"--",
                @"';",
                @"/*",
                @"*/",
                @"@@",
                @"exec(",
                @"execute(",
                @"xp_cmdshell",
                @"sp_configure",
                @"ALTER TABLE",
                @"DROP TABLE",
                @"DELETE FROM",
                @"INSERT INTO",
                @"UPDATE SET"
            };

            foreach (var pattern in dangerousPatterns)
            {
                if (input.Contains(pattern, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }

        private static bool ContainsUrls(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;

            var urlPattern = @"(https?:\/\/|www\.)[^\s]+";
            return Regex.IsMatch(input, urlPattern, RegexOptions.IgnoreCase);
        }

        private static bool ContainsEmailAddresses(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;

            var emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
            return Regex.IsMatch(input, emailPattern);
        }

        private static bool AllowUrls => false; // Mettre à true si vous voulez autoriser les URLs
    }
}
