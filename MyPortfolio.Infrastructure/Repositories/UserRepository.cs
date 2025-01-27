using Microsoft.EntityFrameworkCore;
using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Models;
using MyPortfolio.Infrastructure.Data;
using MyPortfolio.Infrastructure.Repositories.Generics;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<ApplicationUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<ApplicationUser?> GetUserByEmailAsync(string email)
        {
            var user = await _entities
                .Where(u => u.Email == email)
                .Select
                    (u =>
                        new ApplicationUser
                        {
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            Adresses = u.Adresses.Where(a => a.IsActive),
                            Email = u.Email,
                            Birthday = u.Birthday,
                            Degree = u.Degree,
                            Website = u.Website,
                            PhoneNumber = u.PhoneNumber,
                            Profession = u.Profession,
                            Summary = u.Summary,
                            FreelanceAvailable = u.FreelanceAvailable
                        }
                    ).FirstOrDefaultAsync();

            return user;
        }
    }
}
