using System;
using Base.Internal.Interface;

namespace Imp.Services
{
    public class MechnicalService : IMechnicalService
    {
        float randomBill = 100f;
        public string RaiseRequest(IVehicle vehicle, MSData data)
        {
            return "TBD0x001";
        }

        public ServiceData.ServiceStatus CheckStatus(string serviceId)
        {
            return ServiceData.ServiceStatus.Completed;
        }

        public float GetBill(string serviceId)
        {
            randomBill += 10f;
            return randomBill;
        }

        public float GetEstimate(string serviceId)
        {
            return randomBill += 5f;
        }

       
    }
}
