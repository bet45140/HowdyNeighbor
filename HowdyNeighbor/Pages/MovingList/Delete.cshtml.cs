using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HowdyNeighbor.Pages.MovingList
{
    public class DeleteModel : PageModel
    {
        private readonly Data.HowdyNeighborContext _context;
        public DeleteModel(Data.HowdyNeighborContext context)
        {
            _context = context;
        }
        [BindProperty]
        public ChecklistTask ChecklistTask { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ChecklistTask = await _context.ChecklistTask.FirstOrDefaultAsync(task => task.Id == id);
            if (ChecklistTask == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ChecklistTask = await _context.ChecklistTask.FindAsync(id);
            if (ChecklistTask != null)
            {
                _context.ChecklistTask.Remove(ChecklistTask);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./MovingList");
        }
    }
}
