using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class MovingListModel : PageModel
    {
        public static int id = 1;
        public static List<ChecklistTask> ChecklistTasks = new List<ChecklistTask>();
        public static List<int> IDs = new List<int>();
        public IActionResult OnGet()
        {
            // TODO: Redo this code, this is just for testing purposes.
            // The real way to do this would be to have a loop that reads tasks from Firebase and adds them to the list.
            if (!ChecklistTasks.Any())
            {
                DateTime CurrentDate = DateTime.Now; // Current date
                ChecklistTask TaskA = new ChecklistTask(id++, "Make sure that utilities are set up", false, CurrentDate);
                ChecklistTask TaskC = new ChecklistTask(id++, "Transfer perscriptions to new pharmacy", false, CurrentDate.AddDays(1));
                ChecklistTask TaskE = new ChecklistTask(id++, "Get in contact with new neighbors", false, CurrentDate.AddDays(6));
                ChecklistTask TaskF = new ChecklistTask(id++, "Purchase parks membership", false, CurrentDate.AddDays(14));
                ChecklistTasks.Add(TaskA);
                ChecklistTasks.Add(TaskC);
                ChecklistTasks.Add(TaskE);
                ChecklistTasks.Add(TaskF);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            string task = String.Format("{0}", Request.Form["customTask"]);
            DateTime date = DateTime.Now;
            if (Request.Form["taskDate"].ToString() != "")
            {
                date = Convert.ToDateTime(String.Format("{0}", Request.Form["taskDate"]));
            }
            foreach (string item in Request.Form["premadeTasks"])
            {
                ChecklistTask TaskX = new ChecklistTask(1, item, false, date);
                ChecklistTasks.Add(TaskX);
            }
            ChecklistTask TaskG = new ChecklistTask(1, task, false, date);
            if (task != "" && date != null)
            {
                ChecklistTasks.Add(TaskG);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }    
            return Page();
        }
    }
}
