using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Interface
{
    public interface IEncryptor
    {
        byte[] Encrypt(byte[] stream);
        byte[] DeEncrypt(byte[] stream);
    }
}
