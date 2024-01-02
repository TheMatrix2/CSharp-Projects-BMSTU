using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Authors;

public class DeleteAuthor : PageModel
{
    private Services.ICollection<Author> _db;

    public DeleteAuthor(Services.ICollection<Author> db)
    {
        _db = db;
    }
    
    [BindProperty]
    public Author? Author { get; set; }
    
    public IActionResult OnGet(int id)
    {
        Author = _db.Get(id);
        if (Author == null)
        {
            return RedirectToPage("../Error");
        }

        return Page();
    }

    public IActionResult OnPost()
    {
        _db.Delete(Author.ID);
        return RedirectToPage("./Index");
    }
}