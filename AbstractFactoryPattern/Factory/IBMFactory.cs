using AbstractFactoryPattern.Product;
using static AbstractFactoryPattern.Product.IBMProduct;

namespace AbstractFactoryPattern.Factory
{
    public class IBMFactory : IDeviceFactory
    {
        public IDevice CreateMobile()
        {
            return new IBMMobile();
        }

        public IDevice CreateLaptop()
        {
            return new IBMLaptop();
        }

        public IDevice CreateDesktop()
        {
            return new IBMDesktop();
        }
    }
}
