using System;
using Imp.ServiceFacade;

namespace App.Main.Facade
{
    public class TestFacade
    {
        private ServiceFacade facade;
        public TestFacade()
        {
            facade = new ServiceFacade();
        }
        internal void TestService()
        {
            Console.WriteLine("Welcome to GOGO Vehicle Services. We provide all kind of services for vehicle.");
            Console.WriteLine("Please Choose your option");
            Console.WriteLine("\t1. Cleaning");
            Console.WriteLine("\t2. Towing Service");
            Console.WriteLine("\t3. Vehicle Service");

            int serviceChoice = int.Parse(Console.ReadLine());

            if (serviceChoice == 1)
            {
                TestCleaningService();
            }
            else if(serviceChoice == 2)
            {
                TestTowingService();
            }
            else if (serviceChoice == 3)
            {
                TestVehicleService();
            }
        }

        private void TestVehicleService()
        {
            string id = facade.RaiseServiceRequest();
            Console.WriteLine("Service Request raised : {0}", id);
        }

        private void TestCleaningService()
        {
            string id = facade.RaiseCleaningRequest();
            Console.WriteLine("Service Request raised : {0}", id);

        }

        private void TestTowingService()
        {
            string id = facade.RaiseTowingRequest();
            Console.WriteLine("Service Request raised : {0}", id);
        }
    }
}
