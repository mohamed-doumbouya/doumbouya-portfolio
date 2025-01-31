using Microsoft.EntityFrameworkCore;
using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Models;
using MyPortfolio.Infrastructure.Data;
using MyPortfolio.Infrastructure.Repositories.Generics;
using System.Threading.Tasks;

namespace MyPortfolio.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<ApplicationUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<ApplicationUser?> GetUserAsync()
        {
            var user = await _entities
                .Include(u => u.Adresses)
                .FirstOrDefaultAsync();

            return user;
        }
    }
}
