using System;

namespace Base.Internal.Interface
{
    public interface IMechnicalService
    {
        string RaiseRequest(IVehicle vehicle, MSData data);

        float GetEstimate(string serviceId);
        ServiceData.ServiceStatus CheckStatus(string serviceId);

        float GetBill(string serviceId);

    }

    public class MSData
    {
        public bool OilChangeRequired { get; set; }
        public bool WheelRotationRequired { get; set; }
        public bool WithPickDrop { get; set; }
        public bool WithReplacementCar { get; set; }

        public string OtherIssues { get; set; }
        public string PartReplacementsRequired { get; set; }
    }
}
