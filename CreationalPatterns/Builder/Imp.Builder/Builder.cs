using System;

using Base.CommunicationFramework;
using Imp.Compression;
using Imp.Encoders;
using Impr.Encryptors;

namespace Imp.Builders
{
    public class Builder
    {
        private Channel channel;
        private string encoderType;

        public Builder CreateServerChannel(string address, int port)
        {
            channel = new ServerChannel(address, port);
            channel.Protocol = "tcp";
            channel.Encoder = new ASCIIEncoder();
            encoderType = "ascii";
            channel.Compression = null;
            return this;
        }

        public Builder CreateClientChannel(string address, int port)
        {
            channel = new ClientChannel(address, port);
            channel.Protocol = "tcp";
            channel.Encoder = new ASCIIEncoder();
            encoderType = "ascii";
            channel.Compression = null;
            return this;
        }

        public Builder WithHTTPProtocol()
        {
            channel.Protocol = "HTTP";
            return this;
        }

        public Builder WithCompressionEnabled()
        {
            channel.Compression = new GZCompression();

            return this;
        }

        public Builder WithUTF8Encoding()
        {
            channel.Encoder = new UTF8Encoder();
            encoderType = "utf8";
            return this;
        }

        public Builder WithBase64Encoding()
        {
            // TBD
            return this;
        }

        public Builder WithEncryptionEnabled()
        {
            channel.Encryptor = new RSAEncryptor();
            return this;
        }

        public Channel GetChannel()
        {
            return channel;
        }


    }
}
