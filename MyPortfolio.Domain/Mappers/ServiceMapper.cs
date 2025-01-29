using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Models;
using System.Collections.Generic;

namespace MyPortfolio.Domain.Mappers
{
    public static class ServiceMapper
    {

        public static ServiceDto ConvertToServiceDTO(this Service service)
        {
            if (service == null)
            {
                return null;
            }

            var serviceDTO = new ServiceDto();

            serviceDTO.Id = service.Id;
            serviceDTO.Description = service.Description ?? string.Empty;
            serviceDTO.Summary = service.Summary ?? string.Empty;
            serviceDTO.Title = service.Title;
            serviceDTO.ImgUrl = service.ImgUrl ?? string.Empty;

            return serviceDTO;
        }

        public static IEnumerable<ServiceDto> ConvertToServiceDTOList(this IEnumerable<Service> services)
        {
            foreach (var service in services)
            {
                yield return ConvertToServiceDTO(service);
            }
        }
    }
}
