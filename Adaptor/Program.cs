using Microsoft.Extensions.DependencyInjection;

namespace Adaptor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OldPaymentSystem oldPaymentSystem = new OldPaymentSystem();
            //IPaymentProcessor paymentAdapter = new PaymentAdapter(oldPaymentSystem);
            //ECommercePlatform platform = new ECommercePlatform(paymentAdapter);


            // Setup Dependency Injection
            var serviceProvider = new ServiceCollection()
                .AddSingleton<OldPaymentSystem>()
                .AddTransient<IPaymentProcessor, PaymentAdapter>()
                .AddTransient<ECommercePlatform>()
                .BuildServiceProvider();

            // Resolve ECommercePlatform from the service provider
            var platform = serviceProvider.GetService<ECommercePlatform>();

            // Use the platform to process a payment
            platform?.Checkout("1234-5678-9012-3456", 250.75m);
        }
    }
}
