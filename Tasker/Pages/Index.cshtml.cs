using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Task> Tasks;
        

        private ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            context = _context;
        }

        public void OnGet()
        {
            Tasks = _context.Tasks.OrderBy(x => x.Priority);
        }
    }
}
