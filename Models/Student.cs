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
        public int PriceOfOrder { get; set; }

        public Student()
        {

        }

        public Student(string name, int money, string order, int priceOfOrder)
        {
            Name = name;
            Money = money;
            Order = order;
            PriceOfOrder = priceOfOrder;
        }

        //check enough money
        public string SpendMoney()
        {
            if (Money >= PriceOfOrder)
                return $"Остаток: {Money - PriceOfOrder}";
            else 
                return $"Долг: {PriceOfOrder - Money}";
        }
    }
}