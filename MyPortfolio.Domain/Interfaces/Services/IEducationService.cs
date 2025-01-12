using MyPortfolio.Domain.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Services
{
    public interface IEducationService
    {
        Task<IEnumerable<EducationDto>> GetUserEducations();
    }
}