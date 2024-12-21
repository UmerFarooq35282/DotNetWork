using Microsoft.EntityFrameworkCore;

namespace AjaxLearning.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) :base(options) 
        {
            
        }
        public DbSet<AjaxLearning.Models.Employe> employes { get; set; }
    }
}
