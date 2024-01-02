using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Books;

public class CreateModel : PageModel
{
    private Services.ICollection<Book> _db;

    [BindProperty]
    public Book? Book { get; private set; }
    public IEnumerable<Author> Authors { get; set; }
    public IEnumerable<Publisher> Publishers { get; set; }
    
    public CreateModel(Services.ICollection<Book> db_books,
        Services.ICollection<Author> db_authors,
        Services.ICollection<Publisher> db_publishers)
    {
        _db = db_books;
        Authors = db_authors.GetAll();
        Publishers = db_publishers.GetAll();
    }

    public IActionResult OnGet()
    {
        Book = new Book();
        if (Book == null)
        {
            return RedirectToPage("../Error");
        }
        return Page();
    }

    public IActionResult OnPost(Book book)
    {
        book.AuthorName = Authors.FirstOrDefault(a => a.ID == book.AuthorID).Name;
        book.PublisherName = Publishers.FirstOrDefault(p => p.ID == book.PublisherID).Name;
        _db.Add(book);
        return RedirectToPage("./Index");
    }
}