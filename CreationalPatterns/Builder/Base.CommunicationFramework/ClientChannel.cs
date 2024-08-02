using System;
using System.Net.Sockets;

namespace Base.CommunicationFramework
{
    public class ClientChannel : Channel
    {
        private TcpClient client;
        public ClientChannel(string address, int port)
        {
            base.Address = address;
            base.Port = port;
        }

        public override void Create()
        {
            client = new TcpClient();
        }

        public override void Connect()
        {
            client.Connect(Address, Port);
        }

        public override void Close()
        {
            client.GetStream().Close();
            client.Close();
        }

        public override void SendMessage(string data)
        {
            Console.WriteLine("To Server: [{0}] on port [{1}]", Address, Port);
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sending Message: [{0}] With", data, Console.ForegroundColor);
            Console.ForegroundColor = temp;

            Console.WriteLine("\t-Encoding : {0}", Encoder.ToString());
            Console.WriteLine("\t-Compression : {0} ", Compression == null? "NONE" : Compression.ToString());
            Console.WriteLine("\t-Protocol : {0}", Protocol.ToString());
            Console.WriteLine("\t-Encryption : {0}", Encryptor == null ? "NONE" : Encryptor.ToString());
            return;

            // 1. Protocol - use Protocol property of base class and crate message accordingly
            // if HTTP do base64encoding

            // 2. Check encoding method and encode the complete message accordingly
            var encoded = Encoder.Encode(data);
            // 3. Check compression enabled or not and compress accordingly
            var compressed = Compression.Compress(encoded);

            // 4. Check encryption detail and do the needful
            // TODO
            byte[] stream = (byte[])compressed;
            client.GetStream().Write(stream, 0, stream.Length);
        }

        public override string ReceiveMessage()
        {
            byte[] buffer = new byte[256];
            client.GetStream().Read(buffer, 0, buffer.Length);
            // 1. Check encryption details and do the needful
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
