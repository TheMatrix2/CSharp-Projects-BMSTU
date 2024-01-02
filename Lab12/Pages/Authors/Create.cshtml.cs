using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Authors;

public class CreateAuthor : PageModel
{
    private Services.ICollection<Author> _db;
    
    [BindProperty]
    public Author Author { get; set; }

    public CreateAuthor(Services.ICollection<Author> db)
    {
        _db = db;
    }
    
    public IActionResult OnGet()
    {
        Author = new Author();
        if (Author == null)
        {
            return RedirectToPage("../Error");
        }

        return Page();
    }

    public IActionResult OnPost(Author author)
    {
        _db.Add(author);
        return RedirectToPage("./Index");
    }
}