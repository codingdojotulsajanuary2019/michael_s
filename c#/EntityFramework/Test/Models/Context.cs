using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}

        public DbSet<User> Users {get; set;}
    }
}