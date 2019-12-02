using FluentAssertions;
using Xunit;

namespace Pilgrim.SecretManagement.Tests.UnitTests
{
    public class DoubleSaltedPasswordManagerTests
    {
        [Theory]
        [InlineData("jakebladt.com", "1234567890")]
        public void TestRoundTrip(string plaintext, string salt)
        {
            var manager = new DoubleSaltedPasswordManager("static_nonsense_salt_8");
            var cryptoText = manager.Encrypt(plaintext, salt);
            manager.Decrypt(cryptoText, salt).Should().Be(plaintext);
        }
    }
}
