using Microsoft.EntityFrameworkCore;

namespace Excell_On_Service.ContextFolder
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) :base(options)
        {
            
        }

        public DbSet<Excell_On_Service.Models.Service> Services { get; set; }
        public DbSet<Excell_On_Service.Models.Department> Departments { get; set; }
        public DbSet<Excell_On_Service.Models.TblEmployee> TblEmployee { get; set; }
        public DbSet<Excell_On_Service.Models.SubService> SubServices { get; set; }
        public DbSet<Excell_On_Service.Models.Client> TblClient { get; set; }
        public DbSet<Excell_On_Service.Models.TblCart> CartsDetail { get; set; }
        public DbSet<Excell_On_Service.Models.PymentDetail> PymentDetail { get; set; }

    }
}
