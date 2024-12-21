using Microsoft.EntityFrameworkCore;

namespace SearchingDemo.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) :base(options)
        {
            
        }

        public DbSet<SearchingDemo.Models.Product> Products { get; set; }
        public DbSet<SearchingDemo.Models.Category> Categories { get; set; }
    }
}
