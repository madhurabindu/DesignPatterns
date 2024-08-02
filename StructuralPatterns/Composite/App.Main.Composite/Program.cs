using System;
using Imp.Clients;

namespace App.Main.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Composite Pattern Example----------");

            var temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nDemostrating sending message to a leaf....", Console.ForegroundColor);
            Console.ForegroundColor = temp;
            SingleClient client = new SingleClient("uniquexx");
            client.SendeMessage("Private 1-1 message. Your Math Score in Assessment is 1/10");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nDemonstrating Composite sending message");
            Console.ForegroundColor = temp;
            Broadcaster br = new Broadcaster();
            br.SendeMessage("Message to all. School will reopen on 12th June 2021");
            Console.WriteLine("\n");
        }
    }
}
