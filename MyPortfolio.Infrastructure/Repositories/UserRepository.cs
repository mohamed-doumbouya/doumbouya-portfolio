using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
            
        }

        public async Task<ApplicationUser> GetUserByEmailAsync(string email)
        {
            var user = new ApplicationUser 
            {
                FirstName = "Mohamed",
                LastName = "Doumbouya",
                Adresses = new List<Address> 
                { 
                    new Address
                    {
                        City = "Paris",
                        Country = "France",
                        IsActive = true
                    }
                },
                Email = "test.test@gmail.com",
                Birthday = new DateTime(1999, 9, 16),
                Degree = "Ingénieur Logiciel",
                Website = "www.example.com",
                PhoneNumber = "+123 456 7890",
                Profession = "Ingénieur Logiciel",
                Summary = "Summary Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore\r\nmagna aliqua.",
                FreelanceAvailable = true
            };

            return await Task.FromResult(user);
        }
    }
}
