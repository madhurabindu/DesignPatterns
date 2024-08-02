using System;
using Base.CommunicationFramework;
using Imp.Builders;

namespace Imp.Directors
{
    public class ChattyDirector
    {
        public IChannel ConstructServerChannel()
        {
            Builder builder = new Builder();
            IChannel channel = builder.CreateServerChannel("chatserver", 6000)
                .WithEncryptionEnabled()
                .GetChannel();

            return channel;
        }

        public IChannel ConstructClientChannel()
        {
            Builder builder = new Builder();
            IChannel channel = builder.CreateClientChannel("chatserver", 6000)
                .WithEncryptionEnabled()
                .GetChannel();

            return channel;
        }
    }
}
