using System;
using Base.Interface;

namespace Base.CommunicationFramework
{
    public interface IChannel
    {
        string Address { get; set; }
        int Port { get; set; }
        ICompression Compression { get; set; }
        string Protocol { get; set; }
        IEncoder Encoder { get; set; }
        IEncryptor Encryptor { get; set; }

        void Create();
        void Connect();
        void SendMessage(string data);
        string ReceiveMessage();

        void Close();

    }
    public abstract class Channel : IChannel
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public ICompression Compression { get; set; }
        public string Protocol { get; set; }
        public IEncoder Encoder { get; set; }
        public IEncryptor Encryptor { get; set; }
        public abstract void Create();
        public abstract void Connect();
        public abstract void SendMessage(string data);
        public abstract string ReceiveMessage();

        public abstract void Close();
    }
}
