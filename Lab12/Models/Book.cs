namespace Lab12.Models;

public class Book
{
    public int ID { get; set; }
    public string Title { get; set; }
    public int AuthorID { get; set; }
    public string AuthorName { get; set; }
    public int PublisherID { get; set; }
    public string PublisherName { get; set; }
}