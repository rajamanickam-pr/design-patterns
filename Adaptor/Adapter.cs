namespace Adaptor
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(string accountNumber, decimal amount);
    }

    public class OldPaymentSystem
    {
        public void MakePayment(string cardNumber, double amount)
        {
            Console.WriteLine($"Processing payment of {amount} using card {cardNumber} via the old system.");
        }
    }

    public class PaymentAdapter : IPaymentProcessor
    {
        private readonly OldPaymentSystem _oldPaymentSystem;

        public PaymentAdapter(OldPaymentSystem oldPaymentSystem)
        {
            _oldPaymentSystem = oldPaymentSystem;
        }

        public void ProcessPayment(string accountNumber, decimal amount)
        {
            // Convert decimal to double for the legacy system
            double convertedAmount = (double)amount;
            _oldPaymentSystem.MakePayment(accountNumber, convertedAmount);
        }
    }

    public class ECommercePlatform
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public ECommercePlatform(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void Checkout(string accountNumber, decimal amount)
        {
            _paymentProcessor.ProcessPayment(accountNumber, amount);
        }
    }

}
