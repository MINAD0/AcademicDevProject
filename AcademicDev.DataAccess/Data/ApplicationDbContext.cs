using AcademicDev.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademicDevP.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId=1, Name="C++", DisplayOrder=1},
                new Category { CategoryId=2, Name="C#", DisplayOrder=2});
        }
    }
}
