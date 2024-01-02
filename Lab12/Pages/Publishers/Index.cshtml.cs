using Lab12.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages.Publishers;

public class IndexPublisher : PageModel
{
    private Services.ICollection<Publisher> _db;
    public IEnumerable<Publisher> Publishers { get; set; }
    
    public IndexPublisher(Services.ICollection<Publisher> db)
    {
        _db = db;
    }
    
    public void OnGet()
    {
        Publishers = _db.GetAll();
    }
}