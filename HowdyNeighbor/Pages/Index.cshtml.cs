﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class IndexModel : PageModel
    {

        public IActionResult OnGet()
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Page();
        }
        public IActionResult OnPostSearchList(string searchString)
        {
            TempData["searchString"] = searchString;
            TempData.Keep();
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return RedirectToPage("/SearchList");
        }
    }
}
    