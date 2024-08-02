using System;
using Base.Interfaces;
using FactoryPattern.ConfigRepository;

namespace AppMain_FactoryPattern
{
    public class FactoryCreator
    {
        /// <summary>
        /// singleton instance
        /// </summary>
        private static FactoryCreator instance;

        /// <summary>
        /// factory instance
        /// </summary>
        private static ConfigRepoFactory factory;
        /// <summary>
        /// 
        /// </summary>
        static FactoryCreator()
        {
            instance = new FactoryCreator();
            CreateNewRepository();
        }

        /// <summary>
        /// Return Singleton instance
        /// </summary>
        public static FactoryCreator Instance { get { return instance; } }

        /// <summary>
        /// return the concrete factory
        /// </summary>
        /// <returns></returns>
        public ConfigRepoFactory GetFactory()
        {
            return factory;
        }
        /// <summary>
        /// Create the right repo factory based on the application version
        /// </summary>
        private static void CreateNewRepository()
        {
            // Read App version here..
            string appVer = ApplicationProperties.AppVersion;

            if (appVer.StartsWith("1."))
            {
                // Older version of software, CSV format
                factory = new CSVRepoFactory();
            }
            else if (appVer.StartsWith("2."))
            {
                factory = new XMLRepoFactory();
            }
            else
            {
                // newer version of software
                factory = new JSonRepoFactory();
            }
        }
    }
}
