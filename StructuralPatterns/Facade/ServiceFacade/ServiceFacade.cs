using System;
using System.Collections.Generic;
using Base.External.Interface;
using Base.Internal.Interface;
using Imp.Services;
using static Base.Internal.Interface.ServiceData;

namespace Imp.ServiceFacade
{
    /// <summary>
    /// Service Facade
    /// </summary>
    public class ServiceFacade : IVehicleService, IVehicleServiceRespose
    {
        private IMechnicalService mechnicalService;
        private ICleanService cleanService;
        private ITowingService towingService;

        /// <summary>
        /// 
        /// </summary>
        public ServiceFacade()
        {
            mechnicalService = new MechnicalService();
            cleanService = new CleanService();
            towingService = new TowingService();
        }
        public string RaiseCleaningRequest()
        {
            return string.Empty;
        }

        public string RaiseServiceRequest()
        {
            return string.Empty;
        }

        public string RaiseTowingRequest()
        {
            List<string> serviceList = new List<string>();

            Console.WriteLine("\nWelcome to GOGO Towing Services. Please answe following questions");
            Console.WriteLine("Is the vehicle in movable condition? (Y/N)");
            bool movable = string.Compare(Console.ReadLine(), "y", true)==0;

            Console.WriteLine("What is the type of vehicle? (HMV / LMV/ 2W/ 3W/ VHMV) ?");
            VehicleType vehicleType = (VehicleType)VehicleType.Parse(typeof(VehicleType), Console.ReadLine(), true);

            Console.WriteLine("Please provide the Vehicle Registration Number : ");
            string vehicleNumber = Console.ReadLine();

            Console.WriteLine("Please provide the Source Address of the Vehicle?");
            Console.ReadLine();

            Console.WriteLine("Do you wish to tow the vehicle to our Service center?(Y/N)");
            bool serviceRequired = string.Compare(Console.ReadLine(), "y", true) == 0;

            if (!serviceRequired)
            {
                Console.WriteLine("Please provide the destination address");
                Console.ReadLine();
            }

            int numberOfKms = 28;
            Console.WriteLine("Calculated the Distance to be approximately {0} Kms", numberOfKms);

            float quote = towingService.GetQuote(vehicleType, numberOfKms);
            Console.WriteLine("Estimate for the Towing service you requested is : {0}");
            Console.WriteLine("Go Ahead and Book your Request ? (Y/N)");
            bool resp = string.Compare(Console.ReadLine(), "y", true) == 0;
            if (resp)
            {
                string id = towingService.RequestService(movable, vehicleType, numberOfKms);
                serviceList.Add(id);
                if (serviceRequired)
                {
                    IVehicle vehicle = GetVehicleDetails(vehicleNumber);
                    MSData data = GetMSData();
                    
                    id = mechnicalService.RaiseRequest(vehicle, data);
                    serviceList.Add(id);

                    Console.WriteLine("Do you need Deep cleaning of your vehicle?");
                    bool clean = string.Compare(Console.ReadLine(), "y", true) == 0;
                    if (clean)
                    {
                        id = cleanService.RaiseRequest(vehicle, CleanType.DeepClean, CleanAt.ServiceCenter);
                        serviceList.Add(id);
                    }
                }
            }

            return String.Join(",", serviceList.ToArray());
        }

        private IVehicle GetVehicleDetails(string vehicleNumber)
        {
            IVehicle vehicle = new IVehicle();
            Console.WriteLine("Please Provide the Vehicle Model");
            vehicle.Model = Console.ReadLine();
            vehicle.Number = vehicleNumber;

            return vehicle;
        }

        private MSData GetMSData()
        {
            Console.WriteLine("Do You Need a Replacement Car during the time your vehicle is Serviced?");
            bool replacement = string.Compare(Console.ReadLine(), "y", true) == 0;

            MSData data = new MSData()
            {
                OilChangeRequired = false,
                WithPickDrop = false,
                WithReplacementCar = replacement
            };

            return data;
        }
        public string CheckServiceStatus(string serviceId)
        {
            return string.Empty;
        }

        void IVehicleServiceRespose.UpdateResponse(string serviceId, ServiceData.Response response)
        {
        }
    }
}
