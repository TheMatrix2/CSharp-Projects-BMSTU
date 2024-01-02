namespace Lab13.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
    }
}
