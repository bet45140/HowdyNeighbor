using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages.MovingList
{
    public class CreateModel : PageModel
    {
        private readonly Data.HowdyNeighborContext _context;
        public CreateModel(Data.HowdyNeighborContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public ChecklistTask ChecklistTask { get; set; }
        #region snippet
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.ChecklistTask.Add(ChecklistTask);
            await _context.SaveChangesAsync();
            return RedirectToPage("./MovingList");
        }
        #endregion
    }
}
