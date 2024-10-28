namespace EventsDelegates
{
    internal class Program
    {
        public class StockPriceChangedEventArgs : EventArgs
        {
            public string StockSymbol { get; }
            public decimal NewPrice { get; }

            public StockPriceChangedEventArgs(string stockSymbol, decimal newPrice)
            {
                StockSymbol = stockSymbol;
                NewPrice = newPrice;
            }
        }

        //custom delegate
        public delegate void CustomDelegate(string print);

        public class Stock
        {
            // Delegate for stock price change event handler
            public delegate void StockPriceChangedHandler(object sender, StockPriceChangedEventArgs e);

            // Event for notifying stock price changes
            public event StockPriceChangedHandler StockPriceChanged;
            
            // Default event handler can be used with custom args
            //public event EventHandler<StockPriceChangedEventArgs> StockPriceChanged;

            private decimal price;
            public string Symbol { get; }

            public Stock(string symbol, decimal initialPrice)
            {
                Symbol = symbol;
                price = initialPrice;
            }

            // Property for updating the stock price and raising the event
            public decimal Price
            {
                get { return price; }
                set
                {
                    if (price != value)
                    {
                        price = value;
                        OnStockPriceChanged(new StockPriceChangedEventArgs(Symbol, value));
                    }
                }
            }

            // Method for raising the stock price change event
            protected virtual void OnStockPriceChanged(StockPriceChangedEventArgs e)
            {
                StockPriceChanged?.Invoke(this, e);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CustomDelegate customDelegate = PrintMyString;
            customDelegate += PrintMyString2;

            customDelegate("Hello There");

            // Create a new stock instance
            Stock appleStock = new Stock("AAPL", 150.00m);

            // Subscribe multiple investors to the stock price change event
            appleStock.StockPriceChanged += Investor1_StockPriceChanged;
            appleStock.StockPriceChanged += Investor2_StockPriceChanged;

            // Simulate stock price changes
            appleStock.Price = 155.00m;
            appleStock.Price = 160.00m;
        }

        private static void PrintMyString(string print)
        {
            Console.WriteLine(print);
        }

        private static void PrintMyString2(string print)
        {
            Console.WriteLine(print);
        }

        // Event handler method for Investor 1
        private static void Investor1_StockPriceChanged(object sender, StockPriceChangedEventArgs e)
        {
            Console.WriteLine($"Investor 1: The price of {e.StockSymbol} changed to {e.NewPrice:C}");
        }

        // Event handler method for Investor 2
        private static void Investor2_StockPriceChanged(object sender, StockPriceChangedEventArgs e)
        {
            Console.WriteLine($"Investor 2: The price of {e.StockSymbol} changed to {e.NewPrice:C}");
        }
    }
}
