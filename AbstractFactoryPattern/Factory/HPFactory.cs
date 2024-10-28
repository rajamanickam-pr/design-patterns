using AbstractFactoryPattern.Product;
using static AbstractFactoryPattern.Product.HpProduct;

namespace AbstractFactoryPattern.Factory
{
    public class HPFactory : IDeviceFactory
    {
        public IDevice CreateMobile()
        {
            return new HPMobile();
        }

        public IDevice CreateLaptop()
        {
            return new HPLaptop();
        }

        public IDevice CreateDesktop()
        {
            return new HPDesktop();
        }
    }
}
