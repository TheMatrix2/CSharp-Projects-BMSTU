using Lab12.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Books;

public class DetailsModel : PageModel
{
    private Services.ICollection<Book> _db_books;
    private Services.ICollection<Publisher> _db_publishers;
    private Services.ICollection<Author> _db_authors;
    public Book? Book { get; private set; }
    
    public DetailsModel(Services.ICollection<Book> db_books, 
        Services.ICollection<Publisher> db_publishers,
        Services.ICollection<Author> db_authors)
    {
        _db_books = db_books;
        _db_authors = db_authors;
        _db_publishers = db_publishers;
    }
    
    public void OnGet(int id)
    {
        Book = _db_books.Get(id);
        Book.PublisherName = _db_publishers.Get(Book.PublisherID).Name;
        Book.AuthorName = _db_authors.Get(Book.AuthorID).Name;
    }
}