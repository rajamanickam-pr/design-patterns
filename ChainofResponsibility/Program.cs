namespace ChainofResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create handlers
            var billingHandler = new BillingSupportHandler();
            var technicalHandler = new TechnicalSupportHandler();
            var generalHandler = new GeneralSupportHandler();

            // Set up the chain
            billingHandler.SetNextHandler(technicalHandler);
            technicalHandler.SetNextHandler(generalHandler);

            // Send requests
            billingHandler.HandleRequest("Billing");
            billingHandler.HandleRequest("Technical");
            billingHandler.HandleRequest("General");
            billingHandler.HandleRequest("Unknown");
        }
    }
}
