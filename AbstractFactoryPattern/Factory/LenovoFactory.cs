using AbstractFactoryPattern.Product;
using static AbstractFactoryPattern.Product.LenovoProduct;

namespace AbstractFactoryPattern.Factory
{
    public class LenovoFactory : IDeviceFactory
    {
        public IDevice CreateMobile()
        {
            return new LenovoMobile();
        }

        public IDevice CreateLaptop()
        {
            return new LenovoLaptop();
        }

        public IDevice CreateDesktop()
        {
            return new LenovoDesktop();
        }
    }
}
