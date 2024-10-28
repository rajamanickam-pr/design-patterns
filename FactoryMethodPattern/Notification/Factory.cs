namespace FactoryMethodPattern.Notification
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        public void Notify(string message)
        {
            INotification notification = CreateNotification();
            notification.Send(message);
        }
    }

    public class EmailNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }

    public class SmsNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }

    public class PushNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
}
