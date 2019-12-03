using FluentAssertions;
using Xunit;

namespace Pilgrim.SecretManagement.Tests.UnitTests
{
    public class SaltGeneratorTests
    {
        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(128)]
        [InlineData(512)]
        [InlineData(3072)]
        public void RandomSaltsMatchRequestedLength(int length)
        {
            var gen = new SaltGenerator();
            var salt = gen.GenerateSalt(length);
            salt.Length.Should().Be(length);
        }

        [Theory]
        [InlineData(new byte[] { 8 }, "H")]
        [InlineData(new byte[] { 0, 0, 0, 0, 0, 8 }, "H")]
        public void EncodingWorks(byte[] bytes, string expected)
        {
            var gen = new SaltGenerator();
            var encoding = gen.Encode(bytes);
            encoding.Should().Be(expected);
        }
    }
}
