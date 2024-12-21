using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeToMVCCore.Models;

namespace PracticeToMVCCore.Data
{
    public class PracticeToMVCCoreContext : DbContext
    {
        public PracticeToMVCCoreContext (DbContextOptions<PracticeToMVCCoreContext> options)
            : base(options)
        {
        }

        public DbSet<PracticeToMVCCore.Models.Student> Student { get; set; } = default!;
        public DbSet<PracticeToMVCCore.Models.Fees> Fees { get; set; } = default!;
    }
}
