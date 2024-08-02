using System;

namespace Base.Internal.Interface
{
    public class ServiceData
    {
        public enum VehicleType { HMV, LMV, TwoWheeler, ThreeWheeler, VHMV };

        public enum CleanType { DryClean, Wash, DeepClean };

        public enum CleanAt { Home, ServiceCenter};

        public enum ServiceStatus { Raised, Ongoing, Completed};

        public enum ResponseType { Completed, NotServiceable, ServicedWithObservations};
        
        public class Response
        {
            public ResponseType Type { get; set; }
            public string Message { get; set; }
        }
    }
}
