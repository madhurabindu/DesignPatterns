using System;
using System.Collections.Generic;
using Base.Interface;

namespace Imp.Encoders
{
    public class Base64Encoder : IEncoder
    {
        private Dictionary<string, IEncoder> encoderMap;
        public Base64Encoder(string encdertype)
        {
            encoderMap = new Dictionary<string, IEncoder>();
            encoderMap["utf8"] = new UTF8Encoder();
            encoderMap["ascii"] = new ASCIIEncoder();

            EncoderType = encdertype;
        }

        public string EncoderType { get; }

        public object Encode(string data)
        {
            byte[] byteStream = null;
            if (encoderMap.ContainsKey(EncoderType))
            {
                byteStream = (byte[])encoderMap[EncoderType].Encode(data);
            }

            string temp = string.Empty;
            if (byteStream != null)
            {
                temp = Convert.ToBase64String(byteStream);
            }
            return temp;
        }

        public string Decode(object data)
        {
            var byteStream = Convert.FromBase64String((string)data);

            string temp = string.Empty;
            if (encoderMap.ContainsKey(EncoderType))
            {
                temp = encoderMap[EncoderType].Decode(byteStream);
            }
            return temp;
        }

    }
}
