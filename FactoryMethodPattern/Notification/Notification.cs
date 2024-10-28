namespace FactoryMethodPattern.Notification
{
    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Email Notification: " + message);
        }
    }

    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending SMS Notification: " + message);
        }
    }

    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Push Notification: " + message);
        }
    }
}
