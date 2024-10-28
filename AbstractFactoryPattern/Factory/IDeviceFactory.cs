using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern.Factory
{
    public interface IDeviceFactory
    {
        IDevice CreateMobile();
        IDevice CreateLaptop();
        IDevice CreateDesktop();
    }
}
