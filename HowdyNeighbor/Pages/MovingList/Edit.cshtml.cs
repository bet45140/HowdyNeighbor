using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HowdyNeighbor.Pages.MovingList
{
    public class EditModel : PageModel
    {
        private readonly Data.HowdyNeighborContext _context;
        public EditModel(Data.HowdyNeighborContext context)
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
            ChecklistTask = await _context.ChecklistTask.FirstOrDefaultAsync(item => item.Id == id);
            if (ChecklistTask == null)
            {
                return NotFound();
            }
            return Page();
        }
        #region snippet
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Attach(ChecklistTask).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChecklistTaskExists(ChecklistTask.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("./MovingList");
        }
        private bool ChecklistTaskExists(int id)
        {
            return _context.ChecklistTask.Any(item => item.Id == id);
        }
        #endregion
    }
}
