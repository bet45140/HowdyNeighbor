using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class SchoolDistrictModel : PageModel
    {
        public static List<School> schoolList = new List<School>();
        public IActionResult OnGet()
        {
            string searchString = TempData["searchString"] as string;
            TempData.Keep();
            ViewData["searchString"] = searchString;

            School elementarySchool = new School("Merwin Elementary", "1040 Gaskins Rd, Cincinnati, OH 45245", "(513) 947-7800");
            School gradeSchool = new School("West Clermont Middle School", "1341 Clough Pike, Batavia, OH 45103", "(513) 947-7400");
            School highSchool = new School("West Clermont High School", "4101 Bach Buxton Rd, Batavia, OH 45103", "(513) 947-7600");

            schoolList.Add(elementarySchool);
            schoolList.Add(gradeSchool);
            schoolList.Add(highSchool);

            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Page();
        }

        public IActionResult OnPostSearchList(string schoolImportance)
        {
            TempData["schoolImportance"] = schoolImportance;
            TempData.Keep();
            
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return RedirectToPage("/SearchList");
        }
    }
}