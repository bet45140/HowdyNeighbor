﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class AgeDemographics_LoggedInModel : PageModel
    {
        public void OnGet()
        {
            string searchString = TempData["searchString"] as string;
            TempData.Keep();
            ViewData["searchString"] = searchString;
        }
        public IActionResult OnPostSearchList_LoggedIn(string ageImportance)
        {
            TempData["ageImportance"] = ageImportance;
            TempData.Keep();
            return RedirectToPage("/SearchList_LoggedIn");
        }
    }
}