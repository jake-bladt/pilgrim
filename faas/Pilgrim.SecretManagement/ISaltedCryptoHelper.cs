namespace Pilgrim.SecretManagement
{
    public interface ISaltedCryptoHelper
    {
        string Encrypt(string plaintext, string salt);
        string Decrypt(string cryptotext, string salt);
    }
}
