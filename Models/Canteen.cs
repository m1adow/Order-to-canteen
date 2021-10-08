﻿using System;
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
        public int IdOfDish = 0;

        public Canteen(string nameOfDish)
        {
            NameOfDish = nameOfDish;
            IdOfDish++;
        }
    }
}
