using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HowdyNeighbor.Pages
{
    public class MovingListModel : PageModel
    {
        private readonly Data.HowdyNeighborContext _context;

        public MovingListModel(Data.HowdyNeighborContext context)
        {
            _context = context;
        }
        public IList<ChecklistTask> ChecklistTask { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            ChecklistTask = await _context.ChecklistTask.ToListAsync();
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Page();
        }
    }
}
