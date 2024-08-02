using System;
using System.Collections;
using System.Collections.Generic;
using Base.Internal.Interface;

namespace Imp.Services
{
    public class CleanService : ICleanService
    {
        private class Data
        {
            public ServiceData.CleanType Type;
            public ServiceData.CleanAt CleanAt;
            public float Bill;
            public float Quote;
            public IVehicle Vehicle;
            public string ServiceId;
            public ServiceData.ServiceStatus Status;
            public Data()
            {
                Bill = 0f;
                Status = ServiceData.ServiceStatus.Raised;
            }
        }

        private IDictionary<ServiceData.CleanType, float> rateCard;
        /// <summary>
        /// 
        /// </summary>
        private float atHomeCleaningCost;
        /// <summary>
        /// 
        /// </summary>
        private IDictionary<string,Data> dictionary;
        /// <summary>
        /// 
        /// </summary>
        public CleanService()
        {
            dictionary = new Dictionary<string, Data>();
            rateCard = new Dictionary<ServiceData.CleanType, float>();
            rateCard[ServiceData.CleanType.DeepClean] = 32.2f;
            rateCard[ServiceData.CleanType.DryClean] = 16.6f;
            rateCard[ServiceData.CleanType.Wash] = 12.8f;
            atHomeCleaningCost = 10f;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="type"></param>
        /// <param name="cleanAt"></param>
        /// <returns></returns>
        public string RaiseRequest(IVehicle vehicle, ServiceData.CleanType type, ServiceData.CleanAt cleanAt)
        {
            string id = "Clean0x008";
            Data data = new Data()
            {
                Vehicle = vehicle,
                Type = type,
                CleanAt = cleanAt,
                ServiceId = id
            };
            data.Quote = rateCard[type];
            dictionary[id]= data;
            // Spawn a thread and start the process here.. 
            return id;
        }

        public ServiceData.ServiceStatus CheckRequestStatus(string serviceId)
        {
            return dictionary[serviceId].Status;
        }

        public float GetBill(string serviceId)
        {
            // compute bill for the serviceId and return
            Data data = dictionary[serviceId];
            float bill = data.Quote;
            if (data.CleanAt == ServiceData.CleanAt.Home)
            {
                bill += atHomeCleaningCost;
            }

            bill += AddVehicleSpecificCost(data.Vehicle);


            return bill;
        }

        /// <summary>
        /// TO BE IMPLEMENTED
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        private float AddVehicleSpecificCost(IVehicle vehicle)
        {
            return 0f;
        }

        public float GetQuote(ServiceData.CleanType cleanType)
        {
            return rateCard[cleanType];
        }

       
    }
}
