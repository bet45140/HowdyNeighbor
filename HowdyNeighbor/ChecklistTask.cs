using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HowdyNeighbor
{
    public class ChecklistTask
    {
        public String Action { get; set; }

        // TODO: Status should probably be an enum value instead of a string - it is either "in progress", "completed", etc. 
        public String Status { get; set; }
        public DateTime Date { get; set; }
        public ChecklistTask(String action, String status, DateTime date)
        {
            this.Action = action;
            this.Status = status;
            this.Date = date;
        }
    }
}

