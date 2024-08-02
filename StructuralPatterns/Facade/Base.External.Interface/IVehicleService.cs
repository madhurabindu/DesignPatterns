using System;

namespace Base.External.Interface
{
    public interface IVehicleService
    {
        string RaiseServiceRequest();
        string RaiseTowingRequest();
        string RaiseCleaningRequest();

        string CheckServiceStatus(string serviceId);
    }

}
