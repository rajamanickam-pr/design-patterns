namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new OrderBuilder()
                  .SetMainCourse("Grilled Chicken")
                  .SetSideDish("Caesar Salad")
                  .SetDrink("Lemonade")
                  .SetDessert("Cheesecake")
                  .SetTakeAway(true)
                  .Build();

            // Display the order details
            Console.WriteLine(order.ToString());

            Console.WriteLine("Hello, World!");
        }
    }
}
