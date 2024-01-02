using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Authors;

public class EditAuthor : PageModel
{
    private Services.ICollection<Author> _db;
    
    [BindProperty]
    public Author? Author { get; private set; }
    
    public EditAuthor(Services.ICollection<Author> db)
    {
        _db = db;
    }
    
    public IActionResult OnGet(int? id)
    {
        if (id.HasValue)
        {
            Author = _db.Get(id);
        }
        else
        {
            Author = new Author();
        }
        
        if (Author == null)
        {
            return RedirectToPage("../Error");
        }

        return Page();
    }

    public IActionResult OnPost(Author author)
    {
        _db.Edit(author);
        
        return RedirectToPage("./Index");
    }
}
