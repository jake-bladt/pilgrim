using System;
using System.Collections.Generic;
using System.Text;

namespace Pilgrim.SecretManagement
{
    public interface ISaltGenerator
    {
        byte[] GenerateSalt(int byteLength);
        string Encode(byte[] byteArray);
    }

    public class SaltGenerator : ISaltGenerator
    {
        public string Encode(byte[] byteArray)
        {
            throw new NotImplementedException();
        }

        public byte[] GenerateSalt(int byteLength)
        {
            throw new NotImplementedException();
        }
    }
}
