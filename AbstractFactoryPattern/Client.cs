using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern
{
    public class Client
    {
        private readonly IDeviceFactory _deviceFactory;
        public Client(IDeviceFactory deviceFactory)
        {
            _deviceFactory = deviceFactory;
        }

        public void CreateAllDevices()
        {
            IDevice lenovoMobile = _deviceFactory.CreateMobile();
            IDevice lenovoLaptop = _deviceFactory.CreateDesktop();
            IDevice lenovoDesktop = _deviceFactory.CreateLaptop();

            lenovoMobile.GetDetails();
            lenovoLaptop.GetDetails();
            lenovoDesktop.GetDetails();
        }
    }
}
