using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Notification
{
    public interface INotification
    {
        void Send();
    }

    public class EmailNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("EMail Sent");
        }
    }

    public class MeassageNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Message Sent");
        }
    }

    public class PushNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Push notiifcation Sent");
        }
    }
}
