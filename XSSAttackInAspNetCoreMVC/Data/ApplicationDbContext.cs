using Microsoft.EntityFrameworkCore;
using XSSAttackInAspNetCoreMVC.Model;

namespace XSSAttackInAspNetCoreMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
