using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class CrimeDataModel : PageModel
    {
        public static List<Crime> crimeList = new List<Crime>();

        public IActionResult OnGet()
        {
            string searchString = TempData["searchString"] as string;
            TempData.Keep();
            ViewData["searchString"] = searchString;

            Crime crimeRate = new Crime("moderate", "low", "low", "very low");
            crimeList.Add(crimeRate);
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Page();
        }


        public IActionResult OnPostSearchList(string crimeImportance)
        {
            TempData["crimeImportance"] = crimeImportance;
            TempData.Keep();
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return RedirectToPage("/SearchList");
        }
    }
}
