using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class SearchList_LoggedInModel : PageModel
    {
        public void OnGet()
        {
            string searchString = TempData["searchString"] as string;
            TempData.Keep();
            ViewData["searchString"] = searchString;

            string schoolImportance = TempData["schoolImportance"] as string;
            TempData.Keep();
            ViewData["schoolImportance"] = schoolImportance;

            string crimeImportance = TempData["crimeImportance"] as string;
            TempData.Keep();
            ViewData["crimeImportance"] = crimeImportance;

            string trafficImportance = TempData["trafficImportance"] as string;
            TempData.Keep();
            ViewData["trafficImportance"] = trafficImportance;

            string ageImportance = TempData["ageImportance"] as string;
            TempData.Keep();
            ViewData["ageImportance"] = ageImportance;
        }

        public IActionResult OnPostSaveChecklistAsync()
        {
            return RedirectToPage("/Index");
        }
    }
}
