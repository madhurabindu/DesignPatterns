using System;

namespace Base.Interface
{
    public interface ICompression
    {
        object Compress(byte[] stream);
        byte[] Decompress(object data);
    }
}
