namespace BuilderPattern
{
    public class Order
    {
        public string MainCourse { get; private set; }
        public string SideDish { get; private set; }
        public string Drink { get; private set; }
        public string Dessert { get; private set; }
        public bool IsTakeAway { get; private set; }

        public Order(string mainCourse, string sideDish, string drink, string dessert, bool isTakeAway)
        {
            MainCourse = mainCourse;
            SideDish = sideDish;
            Drink = drink;
            Dessert = dessert;
            IsTakeAway = isTakeAway;
        }

        public override string ToString()
        {
            return $"Order Details:\n" +
                   $"Main Course: {MainCourse}\n" +
                   $"Side Dish: {SideDish}\n" +
                   $"Drink: {Drink}\n" +
                   $"Dessert: {Dessert}\n" +
                   $"Take Away: {IsTakeAway}\n";
        }
    }

}
