using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MyPortfolio.Domain.Models;

namespace MyPortfolio.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
    }
}
