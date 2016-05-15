using System.Data.Entity;

namespace CodeFirstNewDatabaseSample
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
            : base("name=BloggingContext")
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }

        public virtual DbSet<Post> Posts { get; set; }

        public virtual DbSet<User> Users { get; set; } 
    }
}