namespace FactoryPattern.Notification
{
    public class NotificationFactory
    {
        public INotification SendNotification(string notification)
        {
            switch (notification.ToLower())
            {
                case "email":
                    return new EmailNotification();
                case "sms":
                    return new MeassageNotification();
                case "push":
                    return new PushNotification();
                default:
                    throw new NotSupportedException($"Notification type '{notification}' is not supported.");

            }
        }
    }
}
