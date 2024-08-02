using System;
using Base.CommunicationFramework;
using Imp.Builders;

namespace Imp.Directors
{
    public class SecureDirector
    {
        public IChannel ConstructServerChannel()
        {
            Builder builder = new Builder();
            IChannel channel = builder.CreateServerChannel("localhost", 9000)
                .WithUTF8Encoding()
                .WithCompressionEnabled()
                .WithEncryptionEnabled()
                .GetChannel();

            return channel;
        }

        public IChannel ConstructClientChannel()
        {
            Builder builder = new Builder();
            IChannel channel = builder.CreateClientChannel("localhost", 9000)
                .WithUTF8Encoding()
                .WithCompressionEnabled()
                .WithEncryptionEnabled()
                .GetChannel();

            return channel;
        }
    }
}
