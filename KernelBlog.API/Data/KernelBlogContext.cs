using KernelBlog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace KernelBlog.API.Data
{
    public class KernelBlogContext : DbContext
    {
        public KernelBlogContext(DbContextOptions<KernelBlogContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        
    }
}