using AcademicDev_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademicDev_Temp.Data
{
    public class ApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "C++", DisplayOrder = 1 },
                new Category { CategoryId = 2, Name = "C#", DisplayOrder = 2 });
        }
    }
}
