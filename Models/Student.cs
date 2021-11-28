namespace Order_to_canteen.Models
{
    class Student
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public string Order { get; set; }
        public int PriceOfOrder { get; set; }
        public int CountOfDays { get; set; }
        public bool Monday { get; set; } = true;
        public bool Tuesday { get; set; } = true;
        public bool Wednesday { get; set; } = true;
        public bool Thursday { get; set; } = true;
        public bool Friday { get; set; } = true;

        public Student()
        {

        }

        public Student(string name, int money, string order, int priceOfOrder, bool monday = true, bool tuesday = true, bool wednesday = true, bool thursday = true, bool friday = true)
        {
            Name = name;
            Money = money;
            Order = order;
            PriceOfOrder = priceOfOrder;
            Monday = monday;
            Tuesday = tuesday;
            Wednesday = wednesday;
            Thursday = thursday;
            Friday = friday;
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