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