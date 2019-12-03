using System;
using tmr = Tedd.MoreRandom;

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
            var rng = new Random();
            var ret = new byte[byteLength];
            rng.NextBytes(ret);
            return ret;
        }
    }
}
