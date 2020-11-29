using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class Index_LoggedInModel : PageModel
    {

        public void OnGet()
        {

        }
        public IActionResult OnPostSearchList_LoggedIn(string searchString)
        {
            TempData["searchString"] = searchString;
            TempData.Keep();
            return RedirectToPage("/SearchList_LoggedIn");
        }
    }

}
    