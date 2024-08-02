using System;
using Base.Interface;

namespace Impr.Encryptors
{
    public class RSAEncryptor : IEncryptor
    {
        public byte[] DeEncrypt(byte[] stream)
        {
            return stream;
        }

        public byte[] Encrypt(byte[] stream)
        {
            return stream;
        }
    }
}
