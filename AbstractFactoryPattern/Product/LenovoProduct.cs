namespace AbstractFactoryPattern.Product
{
    internal class LenovoProduct
    {
        public class LenovoMobile : IDevice
        {
            public void GetDetails()
            {
                Console.WriteLine("Lenovo Mobile");
            }
        }

        public class LenovoLaptop : IDevice
        {
            public void GetDetails()
            {
                Console.WriteLine("Lenovo Laptop");
            }
        }

        public class LenovoDesktop : IDevice
        {
            public void GetDetails()
            {
                Console.WriteLine("Lenovo Desktop");
            }
        }
    }
}
