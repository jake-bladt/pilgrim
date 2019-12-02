using System;
using Xunit;

namespace Pilgrim.SecretManagement.Tests.UnitTests
{
    public class SaltGeneratorTests
    {
        [Theory]
        [InlineData("jakebladt.com", "1234567890")]
        public void TestRoundTrip(string plaintext, string salt)
        {

        }
    }
}
