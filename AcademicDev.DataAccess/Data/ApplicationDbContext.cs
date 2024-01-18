using AcademicDev.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AcademicDevP.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId=1, Name="C++", DisplayOrder=1},
                new Category { CategoryId=2, Name="C#", DisplayOrder=2});

            modelBuilder.Entity<Project>().HasData(
                new Project { ProjectId = 1, PrjName = "ChatApp", Description = "Real-time chat application", Image = "chatapp.jpg", GithubLink = "https://github.com/yourusername/ChatApp", CategoryId = 1 },
                new Project { ProjectId = 2, PrjName = "TaskManager", Description = "Simple task management system", Image = "taskmanager.png", GithubLink = "https://github.com/yourusername/TaskManager", CategoryId = 2 },
                new Project { ProjectId = 3, PrjName = "ECommerceSite", Description = "Online e-commerce platform", Image = "ecommercesite.jpg", GithubLink = "https://github.com/yourusername/ECommerceSite" , CategoryId = 1 }
            );
        }
    }
}
