using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HowdyNeighbor
{
    public class ChecklistTask
    {
        public int Id { get; set; }
        public String Action { get; set; }
        public bool IsComplete { get; set; }
        public DateTime Date { get; set; }

        public ChecklistTask()
        {

        }
        
        public ChecklistTask(int id, String action, bool isComplete, DateTime date)
        {
            this.Id = id;
            this.Action = action;
            this.IsComplete = isComplete;
            this.Date = date;
        }
    }
}

