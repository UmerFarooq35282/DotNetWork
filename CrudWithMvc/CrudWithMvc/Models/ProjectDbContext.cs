using Microsoft.EntityFrameworkCore;

namespace CrudWithMvc.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
            
        }
        public DbSet<CrudWithMvc.Models.Category> categories { get; set; }
        public DbSet<CrudWithMvc.Models.Product> products { get; set; }
    }
}
