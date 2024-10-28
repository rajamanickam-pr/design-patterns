using FactoryPattern.Notification;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationFactory factory = new NotificationFactory();

            // Example usage
            INotification emailNotification = factory.SendNotification("email");
            emailNotification.Send();

            INotification smsNotification = factory.SendNotification("sms");
            smsNotification.Send();

            INotification pushNotification = factory.SendNotification("push");
            pushNotification.Send();

            Console.WriteLine("Hello, World!");
        }
    }
}
