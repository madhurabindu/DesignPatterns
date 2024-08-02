using System;

namespace Base.Internal.Interface
{
    public interface ICleanService
    {
        string RaiseRequest(IVehicle vehicle, ServiceData.CleanType type, ServiceData.CleanAt cleanAt);

        ServiceData.ServiceStatus CheckRequestStatus(string serviceId);

        float GetBill(string serviceId);

        float GetQuote(ServiceData.CleanType cleanType);
    }
}
