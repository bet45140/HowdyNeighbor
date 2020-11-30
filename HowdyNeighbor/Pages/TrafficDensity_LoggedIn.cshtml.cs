﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class TrafficDensity_LoggedInModel : PageModel
    {
        public void OnGet()
        {
            string searchString = TempData["searchString"] as string;
            TempData.Keep();
            ViewData["searchString"] = searchString;
        }
        public IActionResult OnPostSearchList_LoggedIn(string trafficImportance)
        {
            TempData["trafficImportance"] = trafficImportance;
            TempData.Keep();
            return RedirectToPage("/SearchList_LoggedIn");
        }
    }
}