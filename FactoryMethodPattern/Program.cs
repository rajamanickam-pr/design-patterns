using FactoryMethodPattern.Notification;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            NotificationCreator emailCreator = new EmailNotificationCreator();
            emailCreator.Notify("Email message content.");

            NotificationCreator smsCreator = new SmsNotificationCreator();
            smsCreator.Notify("SMS message content.");

            NotificationCreator pushCreator = new PushNotificationCreator();
            pushCreator.Notify("Push message content.");
        }
    }
}
