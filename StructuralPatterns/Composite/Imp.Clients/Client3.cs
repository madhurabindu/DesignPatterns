using System;
using Base.Interfaces;

namespace Imp.Clients
{
    public class Client3 : IClient
    {
        public string ServerID { get; private set; }
        /// <summary>
        /// Ctor for a leaf client
        /// </summary>
        /// <param name="connectionString"></param>
        public Client3(string connectionString)
        {
            // Connect to a backend server with connectionString
            ServerID = connectionString;
        }
        /// <summary>
        /// Sending the message to the server
        /// </summary>
        /// <param name="message"></param>
        public void SendeMessage(string message)
        {
            Console.WriteLine("Sending to \n\tClient: {0} \n\tMessage : {1}", ServerID, message);
        }
    }
}
