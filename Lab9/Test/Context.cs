using Microsoft.EntityFrameworkCore;
using Test.Structures;
namespace Test;

public class TickersContext : DbContext
{
    public DbSet<Tickers> Tickers { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "server=localhost;user=root;password=password;database=Tickers;", 
            new MySqlServerVersion(new Version(8, 0, 35))
        );
    }
}