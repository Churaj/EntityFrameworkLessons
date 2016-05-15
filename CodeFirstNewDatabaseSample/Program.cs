using System;
using System.Linq;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new BloggingContext())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var newBlog = new Blog
                {
                    Name = name
                };

                dbContext.Blogs.Add(newBlog);
                dbContext.SaveChanges();

                var query = from blog in dbContext.Blogs
                    orderby blog.Name
                    select blog;

                foreach (var blog in query)
                {
                    Console.WriteLine($"Blog name: {blog.Name}");
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
