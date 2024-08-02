using System;
using Base.Interfaces;
using FactoryPattern.ConfigRepository;

namespace AppMain_FactoryPattern
{
    // Class to mimic a older client code of the repository
    public class Client
    {
        /// <summary>
        /// Client Ctor
        /// </summary>
        public Client()
        {
        }

        /// <summary>
        /// Some operation that needs to access config
        /// </summary>
        public void SomeOperation()
        {
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("<-------- Finding Config for App[{0}] -------->", ApplicationProperties.AppVersion);
            Console.ForegroundColor = temp;
            IConfig config = FactoryCreator.Instance.GetFactory().GetConfig();
            string configData = config.ReadAll();
            Console.WriteLine("Config read: {0}", configData);
            Console.WriteLine("Client is not aware of the concrete class of the config!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("<----------------------------------------------->", ApplicationProperties.AppVersion);
            Console.ForegroundColor = temp;
        }
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            // Change App version to mimic the bahviour of new client
            // 1.* is CSV, 2.* is XML and any other is JSON
            Console.Write("Enter the App Version : ");
            ApplicationProperties.AppVersion = Console.ReadLine();
            Console.WriteLine();
            Client client = new Client();
            client.SomeOperation();
            Console.WriteLine();
            // New version does not need change to client, older repos
            // Only requires a new factory to be created and a new repo to be added
        }

    }
}
