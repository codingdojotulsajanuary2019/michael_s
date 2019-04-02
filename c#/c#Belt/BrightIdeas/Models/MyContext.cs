using Microsoft.EntityFrameworkCore;
 
namespace BrightIdeas.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users {get; set;}
        public DbSet<BrightIdea> BrightIdeas {get; set;}
        public DbSet<Like> Likes {get; set;}


    
    }
}