using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_to_canteen.Models
{
    class Student
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public string Order { get; set; }

        public Student(string name, int money, string order)
        {
            Name = name;
            Money = money;
            Order = order;
        }
    }
}