using CandyStore.Models;
using Microsoft.EntityFrameworkCore;

namespace CandyStore.Data
{
    public class AppDBContext : DbContext
    {
        //Added@5.2
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Candy> Candies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
