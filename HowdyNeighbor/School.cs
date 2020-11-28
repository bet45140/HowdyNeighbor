using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowdyNeighbor
{
    public class School
    {
        public String SchoolName { get; set; }

        public String SchoolAddress { get; set; }

        public String SchoolPhoneNumber { get; set; }

        public School(string schoolName, string schoolAddress, string schoolPhoneNumber)
        {
            this.SchoolName = schoolName;
            this.SchoolAddress = schoolAddress;
            this.SchoolPhoneNumber = schoolPhoneNumber;
        }

    }
}
