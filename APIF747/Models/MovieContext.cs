using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace APIF747.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {

        }

        public DbSet<MovieItem> TodoItems { get; set; }
    }
}

