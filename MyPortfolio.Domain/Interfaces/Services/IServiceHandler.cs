using MyPortfolio.Domain.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Services
{
    public interface IServiceHandler
    {
        Task<IEnumerable<ServiceDto>> GetUserServicesAsync();
    }
}
