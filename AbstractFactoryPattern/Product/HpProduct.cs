namespace AbstractFactoryPattern.Product
{
    internal class HpProduct
    {
        public class HPMobile : IDevice
        {
            public void GetDetails()
            {
                Console.WriteLine("HP Mobile");
            }
        }

        public class HPLaptop : IDevice
        {
            public void GetDetails()
            {
                Console.WriteLine("HP Laptop");
            }
        }

        public class HPDesktop : IDevice
        {
            public void GetDetails()
            {
                Console.WriteLine("HP Desktop");
            }
        }
    }
}
