using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HowdyNeighbor
{
    public class ChecklistTask
    {
        public String action;

        // TODO: Status should probably be an enum value instead of a string - it is either "in progress", "completed", etc. 
        public String status;
        public DateTime date { get; set; }
        public ChecklistTask(String action, String status, DateTime date)
        {
            this.action = action;
            this.status = status;
            this.date = date;
        }
    }
}

