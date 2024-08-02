using System;
using Base.Interfaces;

namespace JSonConfiguration
{
    /// <summary>
    /// Factory Design Pattern : Concrete Product
    /// </summary>
    public class JsonConfig : IConfig
    {
        public void Open(string connectionString)
        {
        }

        public string ReadAll()
        {
            // read config from a json file
            return "Json File config";
        }

        public void WriteAll(string blob)
        {

        }
    }
}
