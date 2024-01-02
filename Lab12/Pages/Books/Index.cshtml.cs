using Lab12.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Books;

public class BooksModel : PageModel
{
    private Services.ICollection<Book> _db;
    
    public IEnumerable<Book>? Books { get; set; }

    public BooksModel(Services.ICollection<Book> db)
    {
        _db = db;
    }
    
    public void OnGet()
    {
        Books = _db.GetAll();
    }
}