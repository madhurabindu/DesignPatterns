using Imp.Report;
using System;

namespace App.Main.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Proxy Pattern Example--------------");
            Console.Write("Enter User Name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter PSWD: ");
            string pswd = GetPassword();
            Console.WriteLine();
            SecurityProxySalesReport report = new SecurityProxySalesReport(userName, pswd);

            // Check if user is authorized
            PrintUserAuthpirzation(report);

            // Print Sales Report
            PrintSalesReport(report);
            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        private static void PrintUserAuthpirzation(SecurityProxySalesReport report)
        {
            // Check if user is authorized
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nChecking if User is Authorized to view the report .... ");
            Console.ForegroundColor = temp;
            Console.WriteLine("Authorized : {0}", report.UserAuthorized);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        private static void PrintSalesReport(SecurityProxySalesReport report)
        {
            // Now if user is authorized then we can access report
            // if not it would give error
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nLets get the Sales Report Details...");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tProductName: {0}", report.ProductName);
            Console.WriteLine("\n\tPecentage of Opportunities Converted to Sales: {0}", report.PercentageOppToSales);
            Console.ForegroundColor = report.UserAuthorized ? ConsoleColor.Cyan : ConsoleColor.Red;
            Console.WriteLine("\n\tProfit Year to Date: {0}", report.ProfitYTD);
            Console.WriteLine("\n\tAverage Weekly Sales Revenue: {0}", report.AverageWeeklySalesRevenue);
            Console.ForegroundColor = temp;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static string GetPassword()
        {
            string pass = "";
            ConsoleKeyInfo key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.Enter) 
            {
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    Console.Write("\b");
                }
                key = Console.ReadKey(true);
            }

            return pass;
        }
    }
}
