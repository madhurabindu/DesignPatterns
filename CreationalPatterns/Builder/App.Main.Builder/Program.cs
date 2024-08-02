using System;
using Base.CommunicationFramework;
using Imp.Directors;

namespace App.Main.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Secure director creates a channel that is secure for communication
            // for large volume of data
            SecureDirector dr = new SecureDirector();
            IChannel channel = dr.ConstructClientChannel();

            Console.WriteLine("Enter a Message to send to Top Secretive Secure Server");
            string message = Console.ReadLine();
            Console.WriteLine();
            channel.SendMessage(message);

            // Chatty director creates a channel that is secure for communication
            // for large volume of data
            ChattyDirector dr2 = new ChattyDirector();
            channel = dr2.ConstructClientChannel();

            Console.WriteLine("\n\nEnter a Message to send to Chat Server");
            message = Console.ReadLine();
            Console.WriteLine();
            channel.SendMessage(message);

            // Web director creates a channel that is secure for communication
            // for large volume of data
            WebDirector dr3 = new WebDirector();
            channel = dr3.ConstructClientChannel();

            Console.WriteLine("\n\nEnter a Message to send to Web Server");
            message = Console.ReadLine();
            Console.WriteLine();
            channel.SendMessage(message);
        }
    }
}
