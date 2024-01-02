namespace Lab12.Models;

public class Publisher
{
    public int ID { get; set; }
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; }
}