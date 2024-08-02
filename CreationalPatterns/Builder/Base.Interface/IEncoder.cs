using System;

namespace Base.Interface
{
    public interface IEncoder
    {
        byte[] Encode(string data);
        string Decode(byte[] data);
    }
}
