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
    }
}
