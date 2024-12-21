using Microsoft.EntityFrameworkCore;

namespace CrudWithAjax.Models
{
    public class ContextClass : DbContext
    {
        public ContextClass(DbContextOptions<ContextClass> options) :base(options)
        {
            
        }
        public DbSet<CrudWithAjax.Models.Employees> employees { get; set; }
    }
}
