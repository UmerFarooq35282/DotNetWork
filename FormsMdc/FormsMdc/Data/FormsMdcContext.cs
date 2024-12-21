using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FormsMdc.Models;

namespace FormsMdc.Data
{
    public class FormsMdcContext : DbContext
    {
        public FormsMdcContext (DbContextOptions<FormsMdcContext> options)
            : base(options)
        {
        }

        public DbSet<FormsMdc.Models.Companies> Companies { get; set; } = default!;
        public DbSet<FormsMdc.Models.Products> Products { get; set; } = default!;
    }
}
