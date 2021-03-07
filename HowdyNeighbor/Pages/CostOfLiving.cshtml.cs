using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class CostOfLivingModel : PageModel
    {
        public void OnGet()
        {
            string searchString = TempData["searchString"] as string;
            TempData.Keep();
            ViewData["searchString"] = searchString;
        }
        public IActionResult OnPostSearchList(string costOfLivingImportance)
        {
            TempData["costOfLivingImportance"] = costOfLivingImportance;
            TempData.Keep();
            return RedirectToPage("/SearchList");
        }
    }
}