using Microsoft.EntityFrameworkCore;
using OrderFormsForMedical.Models;

namespace OrderFormsForMedical.DbContextFolder
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }
        

        
        public DbSet<OrderFormsForMedical.Models.Products> Products { get; set; }
        public DbSet<OrderFormsForMedical.Models.Companies> Companies { get; set; } = default!;
    }
}
