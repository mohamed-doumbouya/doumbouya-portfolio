using MyPortfolio.Domain.DTO;
using MyPortfolio.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Services
{
    public class ServiceHandler : IServiceHandler
    {
        public async Task<IEnumerable<ServiceDto>> GetUserServicesAsync()
        {
            var services = new List<ServiceDto>
                    {
                        new ServiceDto
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new ServiceDto
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new ServiceDto
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new ServiceDto
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new ServiceDto
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        }
                    };

            return await Task.FromResult(services);
        }
    }
}
