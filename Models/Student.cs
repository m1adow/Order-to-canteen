using System.Collections.Generic;
using System.Linq;

namespace Order_to_canteen.Models
{
    class Student
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> Order { get; set; }
        public decimal CostOfOrder { get; set; }
        public bool Monday { get; set; } = true;
        public bool Tuesday { get; set; } = true;
        public bool Wednesday { get; set; } = true;
        public bool Thursday { get; set; } = true;
        public bool Friday { get; set; } = true;

        public Student()
        {

        }

        public Student(string name, decimal money, List<string> order, decimal costOfOrder, bool monday = true, bool tuesday = true, bool wednesday = true, bool thursday = true, bool friday = true, bool sunday = true)
        {
            Name = name;
            Money = money;
            Order = order;
            CostOfOrder = costOfOrder;
            Monday = monday;
            Tuesday = tuesday;
            Wednesday = wednesday;
            Thursday = thursday;
            Friday = friday;
        }

        public List<bool> CountOfDays()
        {
            List<bool> days = new List<bool>() { Monday, Tuesday, Wednesday, Thursday, Friday };
            return days;
        }

        //check enough money
        public string SpendMoney()
        {
            if (Money >= SumOfOrderForWeek())
                return $"Залишок: {Money - SumOfOrderForWeek()}";
            else
                return $"Борг: {SumOfOrderForWeek() - Money}";
        }

        public decimal SumOfOrderForWeek()
        {
            return CostOfOrder * CountOfDays().Where(a => a == true).Count();
        }

        public string BoolToString(bool day)
        {
            return day == true ? "Присутній" : "Відсутній";
        }
    }
}