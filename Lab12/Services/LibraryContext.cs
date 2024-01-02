using Microsoft.EntityFrameworkCore;
using Pomelo;
using Lab12.Models;

namespace Lab12.Services;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Book> Books { get; set; }
    
}