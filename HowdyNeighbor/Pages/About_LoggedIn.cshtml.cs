using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class About_LoggedInModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {

        }
    }
}
