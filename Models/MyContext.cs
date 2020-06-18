using Microsoft.EntityFrameworkCore; 
    namespace WeddingPlanner.Models
    {
        public class MyContext : DbContext
        {
            public MyContext(DbContextOptions options) : base(options) { }
            
						// This is where the models go
            public DbSet<User> Users {get;set;}
            public DbSet<Wedding> Weddings {get;set;}
            public DbSet<Association> Associations {get;set;}
        }
    }