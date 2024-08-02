using System;
using Base.CommunicationFramework;
using Imp.Builders;

namespace Imp.Directors
{
    public class WebDirector
    {
        public IChannel ConstructServerChannel()
        {
            Builder builder = new Builder();
            IChannel channel = builder.CreateServerChannel("someserver", 3000)
                .WithHTTPProtocol()
                .GetChannel();

            return channel;
        }

        public IChannel ConstructClientChannel()
        {
            Builder builder = new Builder();
            IChannel channel = builder.CreateClientChannel("someserver", 3000)
                .WithHTTPProtocol()
                .GetChannel();

            return channel;
        }
    }
}
