using System;
using System.Text;
using Base.Interface;

namespace Imp.Encoders
{
    public class UTF8Encoder : IEncoder
    {
        public byte[] Encode(string data)
        {
            return Encoding.UTF8.GetBytes(data);
        }

        public string Decode(byte[] data)
        {
            return Encoding.UTF8.GetString((byte[])data);
        }

    }
}
