using System;
using System.Text;
using Base.Interface;

namespace Imp.Encoders
{
    public class ASCIIEncoder : IEncoder
    {
        public byte[] Encode(string data)
        {
            return Encoding.ASCII.GetBytes(data);
        }

        public string Decode(byte[] data)
        {
            return Encoding.ASCII.GetString((byte[])data);
        }

    }
}
