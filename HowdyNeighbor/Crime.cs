using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowdyNeighbor
{
    public class Crime
    {
        public String TheftRate { get; set; }

        public String AssaultRate { get; set; }

        public String SexCrimeRate { get; set; }

        public String HomocideRate { get; set; }

        public Crime(string theftRate, string assaultRate, string sexCrimeRate, string homocideRate)
        {
            this.TheftRate = theftRate;
            this.AssaultRate = assaultRate;
            this.SexCrimeRate = sexCrimeRate;
            this.HomocideRate = homocideRate;
        }

    }
}