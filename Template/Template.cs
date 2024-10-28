namespace Template
{
    public abstract class DataProcessor
    {
        // Template Method
        public void ProcessData()
        {
            ReadData();
            ProcessDataDetails();
            SaveData();
        }

        // Steps that can vary
        protected abstract void ReadData();
        protected abstract void ProcessDataDetails();

        // Step that remains the same
        protected void SaveData()
        {
            Console.WriteLine("Saving data to database...");
        }
    }

   public class CSVDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Reading data from CSV file...");
        }

        protected override void ProcessDataDetails()
        {
            Console.WriteLine("Processing CSV data...");
        }
    }

    public class XMLDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Reading data from XML file...");
        }

        protected override void ProcessDataDetails()
        {
            Console.WriteLine("Processing XML data...");
        }
    }
}
