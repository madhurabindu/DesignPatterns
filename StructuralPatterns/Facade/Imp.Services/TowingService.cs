using System;
using Base.Internal.Interface;

namespace Imp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TowingService : ITowingService
    {
        public ServiceData.ServiceStatus CheckStatus(string serviceId)
        {
            return ServiceData.ServiceStatus.Completed;
        }

        public float GetBill(string serviceId)
        {
            return 1020f;
        }

        public float GetQuote(ServiceData.VehicleType vehicleType, int numberOfKilometers)
        {
            return vehicleType == ServiceData.VehicleType.TwoWheeler ? 100f : 1020f;
        }

        public string RequestService(bool isVehicleWorkingCondition, ServiceData.VehicleType type, int numberOfKilometers)
        {
            return "TBD0x003";
        }
    }
}
