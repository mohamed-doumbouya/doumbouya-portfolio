using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Mappers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Services
{
    public class ServiceHandler : IServiceHandler
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceHandler(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task<IEnumerable<ServiceDto>> GetServicesAsync()
        {
            var services = await _serviceRepository.GetAllAsync();
            return services.ConvertToServiceDTOList();
        }

        public async Task<ServiceDto> GetServiceByAsync(int id)
        {
            var service = await _serviceRepository.GetByIdAsync(id);
            return service?.ConvertToServiceDTO();
        }
    }
}
