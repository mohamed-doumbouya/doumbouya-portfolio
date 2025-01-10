using MyPortfolio.Models.DTO;
using MyPortfolio.Services.Interfaces;

namespace MyPortfolio.Services
{
    public class ServiceHandler : IServiceHandler
    {
        public async Task<IEnumerable<ServiceDTO>> GetUserServicesAsync()
        {
            var services = new List<ServiceDTO>
                    {
                        new ServiceDTO
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new ServiceDTO
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new ServiceDTO
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new ServiceDTO
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        },
                        new ServiceDTO
                        {
                            Title = "Magnam dolores",
                            Description = "Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate",
                        }
                    };

            return await Task.FromResult(services);
        }
    }
}
