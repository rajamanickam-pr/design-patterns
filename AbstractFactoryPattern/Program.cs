using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //more abstract way
            var hpFactoryAbs = new HPFactory();
            Client client = new Client(hpFactoryAbs);
            client.CreateAllDevices();

            // Create a Lenovo factory
            IDeviceFactory lenovoFactory = new LenovoFactory();
            IDevice lenovoMobile = lenovoFactory.CreateMobile();
            IDevice lenovoLaptop = lenovoFactory.CreateLaptop();
            IDevice lenovoDesktop = lenovoFactory.CreateDesktop();

            lenovoMobile.GetDetails();
            lenovoLaptop.GetDetails();
            lenovoDesktop.GetDetails();

            // Create an HP factory
            IDeviceFactory hpFactory = new HPFactory();
            IDevice hpMobile = hpFactory.CreateMobile();
            IDevice hpLaptop = hpFactory.CreateLaptop();
            IDevice hpDesktop = hpFactory.CreateDesktop();

            hpMobile.GetDetails();
            hpLaptop.GetDetails();
            hpDesktop.GetDetails();

            // Create an IBM factory
            IDeviceFactory ibmFactory = new IBMFactory();
            IDevice ibmMobile = ibmFactory.CreateMobile();
            IDevice ibmLaptop = ibmFactory.CreateLaptop();
            IDevice ibmDesktop = ibmFactory.CreateDesktop();

            ibmMobile.GetDetails();
            ibmLaptop.GetDetails();
            ibmDesktop.GetDetails();

            // Create an Apple factory
            IDeviceFactory appleFactory = new AppleFactory();
            IDevice appleMobile = appleFactory.CreateMobile();
            IDevice appleLaptop = appleFactory.CreateLaptop();
            IDevice appleDesktop = appleFactory.CreateDesktop();

            appleMobile.GetDetails();
            appleLaptop.GetDetails();
            appleDesktop.GetDetails();
        }
    }
}
