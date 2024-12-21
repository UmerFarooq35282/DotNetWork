using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MDCForms.Models;

namespace MDCForms.Data
{
    public class MDCFormsContext : DbContext
    {
        public MDCFormsContext (DbContextOptions<MDCFormsContext> options)
            : base(options)
        {
        }

        public DbSet<MDCForms.Models.Companies> Companies { get; set; } = default!;
        public DbSet<MDCForms.Models.Products> Products { get; set; } = default!;
    }
}
