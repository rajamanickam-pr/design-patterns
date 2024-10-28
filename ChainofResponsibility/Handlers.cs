using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public abstract class SupportHandler
    {
        protected SupportHandler nextHandler;

        public void SetNextHandler(SupportHandler handler)
        {
            nextHandler = handler;
        }

        public abstract void HandleRequest(string requestType);
    }

    public class BillingSupportHandler : SupportHandler
    {
        public override void HandleRequest(string requestType)
        {
            if (requestType == "Billing")
            {
                Console.WriteLine("Handling billing support request.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(requestType);
            }
        }
    }

    public class TechnicalSupportHandler : SupportHandler
    {
        public override void HandleRequest(string requestType)
        {
            if (requestType == "Technical")
            {
                Console.WriteLine("Handling technical support request.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(requestType);
            }
        }
    }

    public class GeneralSupportHandler : SupportHandler
    {
        public override void HandleRequest(string requestType)
        {
            if (requestType == "General")
            {
                Console.WriteLine("Handling general support request.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(requestType);
            }
            else
            {
                Console.WriteLine("No handler available for the request.");
            }
        }
    }
}
