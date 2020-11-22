using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowdyNeighbor.Pages
{
    public class SearchListModel : PageModel
    {
        public static List<ChecklistTask> ChecklistTasks = new List<ChecklistTask>();
        public void OnGet()
        {
            string searchString = TempData["searchString"] as string;
            ViewData["searchString"] = searchString;

            // TODO: Redo this code, this is just for testing purposes.
            // The real way to do this would be to have a loop that reads tasks from Firebase and adds them to the list.
            if (!ChecklistTasks.Any())
            {
                DateTime CurrentDate = DateTime.Now; // Current date
                ChecklistTask TaskA = new ChecklistTask("Local school district", "[Link to data from API]", CurrentDate);
                ChecklistTask TaskB = new ChecklistTask("Crime data", "[Link to data from API]", CurrentDate);
                ChecklistTask TaskC = new ChecklistTask("Traffic density", "[Link to data from API]", CurrentDate);
                ChecklistTasks.Add(TaskA);
                ChecklistTasks.Add(TaskB);
                ChecklistTasks.Add(TaskC);

            }
        }
    }
}
