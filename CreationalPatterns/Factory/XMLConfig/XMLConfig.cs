using System;
using Base.Interfaces;

namespace Imp.XMLConfig
{
    public class XMLConfig : IConfig
    {
        public void Open(string connectionString)
        {
        }

        public string ReadAll()
        {
            // read config from a json file
            return "XML File config";

        }

        public void WriteAll(string blob)
        {
        }
    }
}
