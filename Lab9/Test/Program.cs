using System.Net;
using Test;
using Test.Structures;
using Microsoft.EntityFrameworkCore;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string[] tickers = File.ReadAllLines("/home/thematrix/CSharpProjects/Lab10/ticker.txt");
//
//         using (var context = new TickersContext())
//         {
//             FillDb(context, tickers);
//
//             Console.WriteLine("Enter a ticker symbol:");
//             var tickerSymbol = Console.ReadLine();
//         }
//     }
//
//     private static void FillDb(TickersContext context, string[] tickers)
//     {
//         List<Tickers> db = new List<Tickers>();
//         for (var i = 0; i < tickers.Length; i++)
//         {
//             var temp = new Tickers
//             {
//                 TickerSymbol = tickers[i]
//             };
//             db.Add(temp);
//         }
//
//         context.Tickers.AddRange(db);
//     }
// }

public class ApplicationContext : DbContext
{
    public DbSet<Tickers> Tickers { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "server=localhost;user=root;password=password;database=Tickers;", 
            new MySqlServerVersion(new Version(8, 0, 11))
        );
    }
}


class Program
{
    static void Main(string[] args)
    {
        // добавление данных
        using (ApplicationContext db = new ApplicationContext())
        {
            Tickers t1 = new Tickers { TickerSymbol = "AACI" };
            Tickers t2 = new Tickers { TickerSymbol = "AACIW" };
            
            db.Tickers.AddRange(t1, t2);
            db.SaveChanges();
        }
        // получение данных
        using (ApplicationContext db = new ApplicationContext())
        {
            var tickers = db.Tickers.ToList();
            Console.WriteLine("Список объектов:");
            foreach (var t in tickers)
            {
                Console.WriteLine($"{t.Id} - {t.TickerSymbol}");
            }
        }
    }
}


