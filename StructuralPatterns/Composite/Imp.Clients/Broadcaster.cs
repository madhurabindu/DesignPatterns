using System;
using System.Collections.Generic;
using Base.Interfaces;

namespace Imp.Clients
{
    /// <summary>
    /// 
    /// </summary>
    public class Broadcaster : IClient
    {
        /// <summary>
        /// list of clients held by composite class
        /// </summary>
        private IList<IClient> internalClients;
        /// <summary>
        /// Ctor initializing the leaf nodes inside a composite class
        /// </summary>
        public Broadcaster()
        {
            internalClients = new List<IClient>();
            internalClients.Add(new Client1("SRV1"));
            internalClients.Add(new Client2("SRV2"));
            internalClients.Add(new Client3("SRV3"));
        }
        /// <summary>
        /// The composite class itself does not do the operation, 
        /// it just forwards the call to EACH its children
        /// </summary>
        /// <param name="message"></param>
        public void SendeMessage(string message)
        {
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("In Broadcaster.. Brodcasing the message to {0} clients", internalClients.Count);
            Console.ForegroundColor = temp;
            foreach (IClient item in internalClients)
            {
                item.SendeMessage(message);
            }
        }
    }
}
