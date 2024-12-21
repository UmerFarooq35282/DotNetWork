using Microsoft.EntityFrameworkCore;

namespace MvcLoginPage.Models
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options) :base(options) { }

        public DbSet<UserLogin> Users { get; set; }
    }
}
