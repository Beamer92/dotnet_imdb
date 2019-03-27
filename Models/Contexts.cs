using Microsoft.EntityFrameworkCore;

namespace ReplaceJS.Models
{
    public class ActorsContext : DbContext
    {
        public ActorsContext(DbContextOptions<ActorsContext> options)
            : base(options)
        {
        }

        public DbSet<actor> actors { get; set; }
    }
}