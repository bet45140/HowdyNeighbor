using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class MovingListModel : PageModel
    {
        public static int taskId = 1;
        public static List<ChecklistTask> ChecklistTasks = new List<ChecklistTask>();
        public static List<int> IDs = new List<int>();
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (!ChecklistTasks.Any())
            {
                DateTime CurrentDate = DateTime.Now; // Current date
                ChecklistTask TaskA = new ChecklistTask(taskId++, "Make sure that utilities are set up", false, CurrentDate);
                ChecklistTask TaskC = new ChecklistTask(taskId++, "Transfer perscriptions to new pharmacy", false, CurrentDate.AddDays(1));
                ChecklistTask TaskE = new ChecklistTask(taskId++, "Get in contact with new neighbors", false, CurrentDate.AddDays(6));
                ChecklistTask TaskF = new ChecklistTask(taskId++, "Purchase parks membership", false, CurrentDate.AddDays(14));
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
