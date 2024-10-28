namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadSafeConfigurationManager configurationManager = ThreadSafeConfigurationManager.GetInstance;
            Console.WriteLine(configurationManager.GetConfigString("key"));

            ConfigurationManager configManager = ConfigurationManager.GetInstance();
            Console.WriteLine(configManager.GetConfigString("key"));

            Console.WriteLine("Hello, World!");
        }
    }
}
