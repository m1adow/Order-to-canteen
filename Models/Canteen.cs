using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_to_canteen.Models
{
    class Canteen
    {
        public string NameOfDish { get; set; }
        public int CostOfDish { get; set; }
        
        public Canteen()
        {

        }

        public Canteen(string nameOfDish, int costOfDish)
        {
            NameOfDish = nameOfDish;
            CostOfDish = costOfDish;
        }
    }
}