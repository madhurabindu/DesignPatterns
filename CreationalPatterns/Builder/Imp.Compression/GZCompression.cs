using System;
using System.IO;
using System.IO.Compression;
using Base.Interface;

namespace Imp.Compression
{
    public class GZCompression : ICompression
    {
        public object Compress(byte[] stream)
        {
            byte[] ret = null;
            using (MemoryStream originalStream = new MemoryStream(stream))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    using (GZipStream compressionStream = new GZipStream(output,
                                  CompressionMode.Compress))
                    {
                        originalStream.CopyTo(compressionStream);
                    }
                    ret = output.ToArray();
                }
            }
            return ret;
        }

        public byte[] Decompress(object data)
        {
            byte[] ret = null;
            using (MemoryStream originalStream = new MemoryStream((byte[])data))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    using (GZipStream decompressionStream = new GZipStream(originalStream,
                                  CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(output);
                    }
                    ret = output.ToArray();
                }
            }
            return ret;

        }
    }
}
