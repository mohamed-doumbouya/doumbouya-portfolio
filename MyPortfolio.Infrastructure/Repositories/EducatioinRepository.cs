using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Models;
using MyPortfolio.Infrastructure.Data;
using MyPortfolio.Infrastructure.Repositories.Generics;

namespace MyPortfolio.Infrastructure.Repositories
{
    public class EducatioinRepository : GenericRepository<Education>, IEducatioinRepository
    {
        #region Constructor
        public EducatioinRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        #endregion Constructor
    }
}
