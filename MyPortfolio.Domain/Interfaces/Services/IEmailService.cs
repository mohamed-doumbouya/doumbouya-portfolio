using MyPortfolio.Domain.Models.ViewModels;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Services
{
    public interface IEmailService
    {
        Task SendMailAsync(ContactViewModel contact);
    }
}
