using Microsoft.EntityFrameworkCore;
using Pomelo;

namespace Lab13.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=127.0.0.1:3306;user=root;password=password;database=library",
                new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}