using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Books;

public class DeleteModel : PageModel
{
    private Services.ICollection<Book> _db;

    public DeleteModel(Services.ICollection<Book> db)
    {
        _db = db;
    }
    
    [BindProperty]
    public Book? Book { get; set; }
    
    public IActionResult OnGet(int id)
    {
        Book = _db.Get(id);
        if (Book == null)
        {
            return RedirectToPage("../Error");
        }

        return Page();
    }

    public IActionResult OnPost()
    {
        _db.Delete(Book.ID);
        return RedirectToPage("./Index");
    }
}