using MyPortfolio.Domain.Interfaces.Repositories.Generics;
using MyPortfolio.Domain.Models;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Repositories
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        Task<Project?> GetProjectWithCategoryAsync(int id);
    }
}
