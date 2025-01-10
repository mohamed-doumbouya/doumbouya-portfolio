using MyPortfolio.Models.DTO;

namespace MyPortfolio.Services.Interfaces
{
    public interface IServiceHandler
    {
        Task<IEnumerable<ServiceDTO>> GetUserServicesAsync();
    }
}
