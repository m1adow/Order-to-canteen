namespace Order_to_canteen.Models
{
    class Canteen
    {
        public string NameOfDish { get; set; }
        public decimal CostOfDish { get; set; }
        
        public Canteen()
        {

        }

        public Canteen(string nameOfDish, decimal costOfDish)
        {
            NameOfDish = nameOfDish;
            CostOfDish = costOfDish;
        }
    }
}