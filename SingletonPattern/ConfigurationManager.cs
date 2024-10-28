namespace SingletonPattern
{
    public class ConfigurationManager
    {
        private static readonly ConfigurationManager configurationManager;
        public static ConfigurationManager GetInstance()
        {
            if(configurationManager == null)
            {
                return new ConfigurationManager();
            }
            return configurationManager;
        }
        public string GetConfigString(string key)
        {
            return "value";
        }

        private ConfigurationManager()
        {

        }
    }

    public class ThreadSafeConfigurationManager
    {
        private static readonly Lazy<ThreadSafeConfigurationManager> configurationManager;
        public static ThreadSafeConfigurationManager GetInstance
        {
            get
            {
                if (configurationManager == null)
                {
                    var instance =  new Lazy<ThreadSafeConfigurationManager>(()=> new ThreadSafeConfigurationManager(),isThreadSafe: true);
                    return instance.Value;
                }
                return configurationManager.Value;
            }
        }

        public string GetConfigString(string key)
        {
            return "value";
        }

        private ThreadSafeConfigurationManager()
        {

        }
    }
}
