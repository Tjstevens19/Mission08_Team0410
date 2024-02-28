using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0410.Models
{
    public class Mission08Context : DbContext
    {
        public Mission08Context(DbContextOptions<Mission08Context> options) : base (options)
        {

        }

        public DbSet<TaskClass> Task {  get; set; }
    }
}