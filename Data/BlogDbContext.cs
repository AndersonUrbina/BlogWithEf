using Microsoft.EntityFrameworkCore;
using BlogWithEf.Models;

namespace BlogWithEf.Data
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }
    }
}