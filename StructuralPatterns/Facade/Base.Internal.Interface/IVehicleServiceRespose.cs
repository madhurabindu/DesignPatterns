using System;

namespace Base.Internal.Interface
{
    public interface IVehicleServiceRespose
    {
        void UpdateResponse(string serviceId, ServiceData.Response response);
    }
}
