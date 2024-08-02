using System;

namespace Base.Internal.Interface
{
    public interface ITowingService
    {
        string RequestService(bool isVehicleWorkingCondition, ServiceData.VehicleType type, int numberOfKilometers);

        ServiceData.ServiceStatus CheckStatus(string serviceId);

        float GetBill(string serviceId);

        float GetQuote(ServiceData.VehicleType cleanType, int numberOfKilometers);

    }
}
