using Microsoft.EntityFrameworkCore;

namespace ReplaceJS.Models
{
    public class ActorsContext : DbContext
    {
        public ActorsContext(DbContextOptions<ActorsContext> options)
            : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
    }
}