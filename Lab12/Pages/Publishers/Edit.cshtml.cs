using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Publishers;

public class EditPublisher : PageModel
{
    private Services.ICollection<Publisher> _db;
    
    [BindProperty]
    public Publisher? Publisher { get; private set; }
    
    public EditPublisher(Services.ICollection<Publisher> db)
    {
        _db = db;
    }
    
    public IActionResult OnGet(int? id)
    {
        if (id.HasValue)
        {
            Publisher = _db.Get(id);
        }
        else
        {
            Publisher = new Publisher();
        }
        
        if (Publisher == null)
        {
            return RedirectToPage("../Error");
        }

        return Page();
    }

    public IActionResult OnPost(Publisher publisher)
    {
        _db.Edit(publisher);
        
        return RedirectToPage("./Index");
    }
}