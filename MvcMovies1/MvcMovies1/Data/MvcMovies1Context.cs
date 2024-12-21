using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovies1.Models;

namespace MvcMovies1.Data
{
    public class MvcMovies1Context : DbContext
    {
        public MvcMovies1Context (DbContextOptions<MvcMovies1Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovies1.Models.Movie> Movie { get; set; } = default!;
    }
}
