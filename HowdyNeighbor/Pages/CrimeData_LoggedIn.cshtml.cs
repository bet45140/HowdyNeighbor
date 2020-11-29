using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class CrimeData_LoggedInModel : PageModel
    {
        public static List<Crime> crimeList = new List<Crime>();

        public void OnGet()
        {
            string searchString = TempData["searchString"] as string;
            TempData.Keep();
            ViewData["searchString"] = searchString;

            Crime crimeRate = new Crime("moderate", "low", "low", "very low");
            crimeList.Add(crimeRate);

        }


        public IActionResult OnPostSearchList_LoggedIn(string crimeImportance)
        {
            TempData["crimeImportance"] = crimeImportance;
            TempData.Keep();
            return RedirectToPage("/SearchList_LoggedIn");
        }
    }
}
