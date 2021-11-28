using System.Collections.Generic;
using System.Linq;

namespace Order_to_canteen.Models
{
    class Student
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public string Order { get; set; }
        public int CostOfOrder { get; set; }
        public bool Monday { get; set; } = true;
        public bool Tuesday { get; set; } = true;
        public bool Wednesday { get; set; } = true;
        public bool Thursday { get; set; } = true;
        public bool Friday { get; set; } = true;
        public bool Sunday { get; set; } = true;

        public Student()
        {

        }

        public Student(string name, int money, string order, int costOfOrder, bool monday = true, bool tuesday = true, bool wednesday = true, bool thursday = true, bool friday = true, bool sunday = true)
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
            Sunday = sunday;
        }

        public List<bool> CountOfDays()
        {
            List<bool> days = new List<bool>() { Monday, Tuesday, Wednesday, Thursday, Friday, Sunday };
            return days;
        }

        //check enough money
        public string SpendMoney()
        {
            if (Money >= SumOfOrderForWeek())
                return $"Остаток: {Money - SumOfOrderForWeek()}";
            else
                return $"Долг: {SumOfOrderForWeek() - Money}";
        }

        public int SumOfOrderForWeek()
        {
            return CostOfOrder * CountOfDays().Where(a => a == true).Count();
        }
    }
}