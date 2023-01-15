using DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public sealed class ForumContext : IdentityDbContext<User>
    {
        public ForumContext(DbContextOptions<ForumContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Forum1;Password=admin;Username=postgres;");
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}