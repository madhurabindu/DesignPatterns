using System;
using System.Net;
using System.Net.Sockets;

namespace Base.CommunicationFramework
{
    public class ServerChannel : Channel
    {
        private TcpListener server = null;
        private TcpClient client = null;
        public ServerChannel(string address, int port)
        {
            base.Address = address;
            base.Port = port;
        }

        public override void Create()
        {
            IPAddress addr = IPAddress.Parse(Address);

            // TcpListener server = new TcpListener(port);
            server = new TcpListener(addr, Port);
            server.Start();
        }

        public override void Connect()
        {
            // Need to create a thread and wait for connections and accept any incoming client
            // for simplicity only a call is made, this wont work
            // idea of this example is to understand the pattern and not implemenation details.
            TcpClient client = server.AcceptTcpClient();
        }

        public override void Close()
        {
            server.Stop();
        }

        public override void SendMessage(string data)
        {
            // 1. Protocol - use Protocol property of base class and crate message accordingly
            // if HTTP do base64encoding

            // 2. Check encoding method and encode the complete message accordingly
            var encoded = Encoder.Encode(data);
            // 3. Check compression enabled or not and compress accordingly
            var compressed = Compression.Compress(encoded);

            // 4. Check encryption detail and do the needful
            byte[] stream = Encryptor?.Encrypt((byte[])compressed);

            client.GetStream().Write(stream, 0, stream.Length);
        }

        public override string ReceiveMessage()
        {
            byte[] buffer = new byte[256];
            client.GetStream().Read(buffer, 0, buffer.Length);
            // 1. Check encryption details and do the needful
            buffer = Encryptor?.DeEncrypt(buffer);
            // 2. check compression enabled or not and decompress
            var decopressed = Compression.Decompress(buffer);

            // 3. check encoding method and decode
            var decoded = Encoder.Decode(decopressed);

            // 4. check protocol and strip protocl to get the message, Base64decode if HTTP
            string message = string.Empty;
            return message;
        }
    }
}
