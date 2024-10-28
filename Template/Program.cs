namespace Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataProcessor csvProcessor = new CSVDataProcessor();
            csvProcessor.ProcessData();

            Console.WriteLine();

            DataProcessor xmlProcessor = new XMLDataProcessor();
            xmlProcessor.ProcessData();
        }
    }
}
