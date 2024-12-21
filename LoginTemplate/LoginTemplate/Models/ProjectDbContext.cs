using Microsoft.EntityFrameworkCore;

namespace LoginTemplate.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
            
        }
        public DbSet<LoginUser> Users { get; set; }
    }

}
