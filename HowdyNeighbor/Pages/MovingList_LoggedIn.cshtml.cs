using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;

namespace HowdyNeighbor.Pages
{
    public class MovingList_LoggedInModel : PageModel
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
                /* ChecklistTask TaskB = new ChecklistTask("Get in contact with the local school district", "In progress", CurrentDate); */
                ChecklistTask TaskC = new ChecklistTask("Transfer perscriptions to new pharmacy", "In progress", CurrentDate.AddDays(1));
                /* ChecklistTask TaskD = new ChecklistTask("Find boxes for household items", "In progress", CurrentDate.AddDays(3)); */
                ChecklistTask TaskE = new ChecklistTask("Get in contact with new neighbors", "In progress", CurrentDate.AddDays(6));
                ChecklistTask TaskF = new ChecklistTask("Purchase parks membership", "In progress", CurrentDate.AddDays(14));
                ChecklistTasks.Add(TaskA);
                /* ChecklistTasks.Add(TaskB); */
                ChecklistTasks.Add(TaskC);
                /* ChecklistTasks.Add(TaskD); */
                ChecklistTasks.Add(TaskE);
                ChecklistTasks.Add(TaskF);
            }
        }
        public void OnPost()
        {
            string task = String.Format("{0}", Request.Form["customTask"]);
            DateTime date = DateTime.Now;
            if (Request.Form["taskDate"].ToString() != "")
            {
                date = Convert.ToDateTime(String.Format("{0}", Request.Form["taskDate"]));
            }
            foreach (string item in Request.Form["premadeTasks"])
            {
                ChecklistTask TaskX = new ChecklistTask(item, "In progress", date);
                ChecklistTasks.Add(TaskX);
            }
            ChecklistTask TaskG = new ChecklistTask(task, "In progress", date);
            if (task != "" && date != null)
            {
                ChecklistTasks.Add(TaskG);
            }
        }
    }
}
