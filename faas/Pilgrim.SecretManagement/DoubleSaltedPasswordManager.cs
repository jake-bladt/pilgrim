using System;

namespace Pilgrim.SecretManagement
{
    public class DoubleSaltedPasswordManager : ISaltedCryptoHelper
    {
        protected string _staticSalt;

        public DoubleSaltedPasswordManager(string staticSalt)
        {
            _staticSalt = staticSalt;
        }

        public string Decrypt(string cryptotext, string salt)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string plaintext, string salt)
        {
            throw new NotImplementedException();
        }
    }
}
