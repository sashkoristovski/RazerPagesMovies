using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazerPagesMovies.Models;

namespace RazerPagesMovies.Data
{
    public class RazerPagesMoviesContext : DbContext
    {
        public RazerPagesMoviesContext (DbContextOptions<RazerPagesMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<RazerPagesMovies.Models.Movie> Movie { get; set; } = default!;
    }
}
