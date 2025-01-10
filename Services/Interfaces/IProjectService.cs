using MyPortfolio.Models.DTO;

namespace MyPortfolio
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectDTO>> GetUserProjectsAsync();
    }
}