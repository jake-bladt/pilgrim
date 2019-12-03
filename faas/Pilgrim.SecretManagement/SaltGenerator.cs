using System;
using System.Text;

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
            var ret = new StringBuilder();
            for(int i = 0; i < byteArray.Length; i += BytesPerChar)
            {
                byte[] forChar = new byte[BytesPerChar];
                Array.Copy(byteArray, i, forChar, 0, BytesPerChar);
                var index = BitConverter.ToInt64(forChar, 0);
                ret.Append(PossibleChars[(Int32)index]);
            }

            return ret.ToString();
        }

        public byte[] GenerateSalt(int byteLength)
        {
            var rng = new tmr.Random();
            return rng.GetByteArray(byteLength);
        }
    }
}
