using Base.Interfaces;
using Imp.DataAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Main.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Testing Adapter for Local SQL Request");
            OrderDataAdapter adapter = new OrderDataAdapter("sql");
            Order orer = adapter.GetOrderData("ORDX12118");

            Console.WriteLine("\n--------------Testng Adapter for Remote Request");
            adapter = new OrderDataAdapter("remote");
            orer = adapter.GetOrderData("ORDX12118");

            Console.WriteLine("\nThe Client calls simple interface on DataAdapter \nhiding the complexiies of SQL/Remote call in the adapter class!!\n\n");

        }
    }
}
