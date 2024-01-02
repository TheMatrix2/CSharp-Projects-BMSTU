using Lab12.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Authors;

public class IndexAuthor : PageModel
{
    private Services.ICollection<Author> _db;
    public IEnumerable<Author> Authors { get; set; }
    
    public IndexAuthor(Services.ICollection<Author> db)
    {
        _db = db;
    }
    
    public void OnGet()
    {
        Authors = _db.GetAll();
    }
}