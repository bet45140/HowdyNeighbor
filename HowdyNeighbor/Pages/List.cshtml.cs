using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;

namespace HowdyNeighbor.Pages
{
    public class ListModel : PageModel
    {
        public static List<ChecklistTask> ChecklistTasks = new List<ChecklistTask>();
        public void OnGet()
        {
            // TODO: Redo this code, this is just for testing purposes.
            // The real way to do this would be to have a loop that reads tasks from Firebase and adds them to the list.
            if (!ChecklistTasks.Any())
            {
                DateTime CurrentDate = DateTime.Now; // Current date
                ChecklistTask TaskA = new ChecklistTask("Make sure that utilities are set up", "In progress", CurrentDate);
                ChecklistTask TaskB = new ChecklistTask("Research the local school district", "In progress", CurrentDate);
                ChecklistTask TaskC = new ChecklistTask("Allocate moving budget", "In progress", CurrentDate);
                ChecklistTasks.Add(TaskA);
                ChecklistTasks.Add(TaskB);
                ChecklistTasks.Add(TaskC);
            }
        }
    }
}
