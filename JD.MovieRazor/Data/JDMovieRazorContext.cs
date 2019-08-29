using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JD.MovieRazor.Models
{
    public class JDMovieRazorContext : DbContext
    {
        public JDMovieRazorContext (DbContextOptions<JDMovieRazorContext> options)
            : base(options)
        {
        }

        public DbSet<JD.MovieRazor.Models.Movie> Movie { get; set; }
    }
}
