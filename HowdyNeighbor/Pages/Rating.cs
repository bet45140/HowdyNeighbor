using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowdyNeighbor.Pages
{
    public class Rating
    {
        public int Id { get; set; }
        public int NumberOfStars { get; set; }

        public Rating()
        {

        }

        public Rating(int id, int numberOfStars)
        {
            this.Id = id;
            this.NumberOfStars = numberOfStars;
        }
    }
}
