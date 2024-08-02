using System;
using Base.Interfaces;

namespace CSVConfiguration
{
    /// <summary>
    /// Factory Design Pattern : Concrete Product 
    /// </summary>
    public class CSVConfig : IConfig
    {
        public void Open(string connectionString)
        {
           
        }

        public string ReadAll()
        {
            // read config from a csv file
            return "CSV File config";
        }

        public void WriteAll(string blob)
        {

        }
    }
}
