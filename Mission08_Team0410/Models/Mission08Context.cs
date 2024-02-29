using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0410.Models
{
    public class Mission08Context : DbContext
    {
        public Mission08Context(DbContextOptions<Mission08Context> options) : base (options)
        {
        }

        public DbSet<CoveyTask> Tasks {  get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryId = 1, CategoryName = "Home" },
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church" }

                );
        }
    }
}