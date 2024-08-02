using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Main.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFacade facade = new TestFacade();
            facade.TestService();
        }
    }
}
