using Lab12.Models;
using Lab12.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Books;

public class EditModel : PageModel
{
    private LibraryContext _db;
    
    [BindProperty]
    public Book? Book { get; private set; }
    public IEnumerable<Author> Authors { get; set; }
    public IEnumerable<Publisher> Publishers { get; set; }
    
    public EditModel(LibraryContext db)
    {
        _db = db;
        Authors = _db.Authors;
        Publishers = _db.Publishers;
    }
    
    public IActionResult OnGet(int? id)
    {
        var book = _db.Books.Find(id);
        
        if (book != null)
        {
            Book? Book = new Book()
            {
                ID = book.ID,
                Title = book.Title,
                AuthorID = book.AuthorID,
                AuthorName = book.AuthorName,
                PublisherID = book.PublisherID,
                PublisherName = book.PublisherName
            };
            return Page();
        }
        else
        {
            return RedirectToPage("../Error");
        }
        
    }
    
    public IActionResult OnPost()
    {
    
        if (Book != null)
        {
            var existingBook = _db.Books.Find(Book.ID);
            if (existingBook != null)
            {
                existingBook.ID = Book.ID;
                existingBook.Title = Book.Title;
                existingBook.AuthorID = Book.AuthorID;
                existingBook.AuthorName = _db.Authors.FirstOrDefault(a => a.ID == existingBook.AuthorID).Name;
                existingBook.PublisherID = Book.PublisherID;
                existingBook.PublisherName = _db.Publishers.FirstOrDefault(p => p.ID == existingBook.PublisherID).Name;
                _db.SaveChanges();
            }
        }
        return RedirectToPage("./Index");
    }
}