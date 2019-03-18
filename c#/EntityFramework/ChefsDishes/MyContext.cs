using Microsoft.EntityFrameworkCore;

namespace ChefsDishes.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}

        public DbSet<Chef> Chef {get; set;}
        public DbSet<Dish> Dish {get ;set;}
    }
}