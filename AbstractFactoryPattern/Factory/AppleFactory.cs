using AbstractFactoryPattern.Product;
using static AbstractFactoryPattern.Product.AppleDevice;

namespace AbstractFactoryPattern.Factory
{
    public class AppleFactory : IDeviceFactory
    {
        public IDevice CreateMobile()
        {
            return new AppleMobile();
        }

        public IDevice CreateLaptop()
        {
            return new AppleLaptop();
        }

        public IDevice CreateDesktop()
        {
            return new AppleDesktop();
        }
    }
}
