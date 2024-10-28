namespace BuilderPattern
{
    public class OrderBuilder
    {
        private string _mainCourse;
        private string _sideDish;
        private string _drink;
        private string _dessert;
        private bool _isTakeAway;

        public OrderBuilder SetMainCourse(string mainCourse)
        {
            _mainCourse = mainCourse;
            return this;
        }

        public OrderBuilder SetSideDish(string sideDish)
        {
            _sideDish = sideDish;
            return this;
        }

        public OrderBuilder SetDrink(string drink)
        {
            _drink = drink;
            return this;
        }

        public OrderBuilder SetDessert(string dessert)
        {
            _dessert = dessert;
            return this;
        }

        public OrderBuilder SetTakeAway(bool isTakeAway)
        {
            _isTakeAway = isTakeAway;
            return this;
        }

        public Order Build()
        {
            return new Order(_mainCourse, _sideDish, _drink, _dessert, _isTakeAway);
        }
    }

}
