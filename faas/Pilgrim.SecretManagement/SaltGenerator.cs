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
        protected readonly string PossibleChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@";
        protected readonly int BytesPerChar = 6;

        public string Encode(byte[] byteArray)
        {
            throw new NotImplementedException();
        }

        public byte[] GenerateSalt(int byteLength)
        {
            var rng = new tmr.Random();
            return rng.GetByteArray(byteLength);
        }
    }
}
