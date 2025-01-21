using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Domain.Interfaces.Repositories;
using MyPortfolio.Domain.Interfaces.Services;
using MyPortfolio.Domain.Models;
using MyPortfolio.Domain.Services;
using MyPortfolio.Infrastructure.Data;
using MyPortfolio.Infrastructure.Repositories;
using MyPortfolio.Infrastructure.Seeder;

namespace MyPortfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Services
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<ISkillService, SkillService>();
            builder.Services.AddScoped<IResumeService, ResumeService>();
            builder.Services.AddScoped<IProjectService, ProjectService>();
            builder.Services.AddScoped<IServiceHandler, ServiceHandler>();
            builder.Services.AddScoped<ITestimonialService, TestimonialService>();
            builder.Services.AddScoped<IEducationService, EducationService>();
            builder.Services.AddScoped<IExperienceService, ExperienceService>();
            #endregion Services

            #region Repositories
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<ISkillRepository, SkillRepository>();
            builder.Services.AddScoped<IResumeRepository, ResumeRepository>();
            #endregion Repositories

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();
            var app = builder.Build();


            using(var scope = app.Services.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetService<UserManager<ApplicationUser>>();
                var roleManager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

                DatabaseSeeder.SeedRoleAsync(roleManager).Wait();
                DatabaseSeeder.SeedUserAsync(userManager).Wait();
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}