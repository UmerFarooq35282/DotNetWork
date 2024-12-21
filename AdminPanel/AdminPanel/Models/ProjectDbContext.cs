using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
            
        }
        public DbSet<PanelUsers> PanelUsers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
