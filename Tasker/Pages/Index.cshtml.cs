using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Task> Tasks;
        public void OnGet()
        {
        }

        private ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            context = _context;
        }
    }
}
