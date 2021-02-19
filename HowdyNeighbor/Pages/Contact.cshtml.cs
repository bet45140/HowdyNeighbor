﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }
        public IActionResult OnGet()
        {
            Message = "Your contact page.";
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Page();
        }
    }
}
