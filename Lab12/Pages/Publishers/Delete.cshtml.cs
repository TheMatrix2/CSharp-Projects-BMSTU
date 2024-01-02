using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Publishers;

public class DeletePublisher : PageModel
{
    private Services.ICollection<Publisher> _db;

    public DeletePublisher(Services.ICollection<Publisher> db)
    {
        _db = db;
    }
    
    [BindProperty]
    public Publisher? Publisher { get; set; }
    
    public IActionResult OnGet(int id)
    {
        Publisher = _db.Get(id);
        if (Publisher == null)
        {
            return RedirectToPage("../Error");
        }

        return Page();
    }

    public IActionResult OnPost()
    {
        _db.Delete(Publisher.ID);
        return RedirectToPage("./Index");
    }
}