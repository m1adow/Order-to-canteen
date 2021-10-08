using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_to_canteen.Models
{
    class SchoolClass
    {
        public int CountOfPupils { get; set; }
        public int Budget { get; set; }

        public SchoolClass(int countOfPupils, int budget)
        {
            CountOfPupils = countOfPupils;
            Budget = budget;
        }
    }
}
