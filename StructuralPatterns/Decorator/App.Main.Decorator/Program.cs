using System;
using Imp.Report;

namespace App.Main.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = Console.ForegroundColor;

            Console.WriteLine("----------- Decorator Pattern Example -------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGenerating Report Without Decorator\n");
            Console.ForegroundColor = temp;

            SalesReport sales = new SalesReport();
            string report = sales.GenerateReport();
            Console.WriteLine(report);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGenerating Report WITH Sales Manager Decorator\n");
            Console.ForegroundColor = temp;

            SalesManagerReportDecorator decorator = new SalesManagerReportDecorator(sales, "Mr. Sugreeva");
            report = decorator.GenerateReport();
            Console.WriteLine(report);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGenerating Report WITH HTML Decorator\n");
            Console.ForegroundColor = temp;

            string filePath = "salesreport.html";
            HTMLReportDecorator htmlDecorator = new HTMLReportDecorator(sales, filePath);
            htmlDecorator.GenerateReport();
            Console.WriteLine("HTML Report Generated and Stored at : {0}", filePath);

            Console.WriteLine();
        }
    }
}
