using Lab12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Publishers;

public class CreatePublisher : PageModel
{
    private Services.ICollection<Publisher> _db;
    
    [BindProperty]
    public Publisher Publisher { get; set; }

    public CreatePublisher(Services.ICollection<Publisher> db)
    {
        _db = db;
    }
    
    public IActionResult OnGet()
    {
        Publisher = new Publisher();
        if (Publisher == null)
        {
            return RedirectToPage("../Error");
        }

        return Page();
    }

    public IActionResult OnPost(Publisher publisher)
    {
        _db.Add(publisher);
        return RedirectToPage("./Index");
    }
}