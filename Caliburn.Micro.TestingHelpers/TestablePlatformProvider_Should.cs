using FluentAssertions;
using NUnit.Framework;

namespace Caliburn.Micro.TestingHelpers
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    class TestablePlatformProvider_Should
    {
        [Test]
        public void Implement_IPlatformProvider()
        {
            var sut = new TestablePlatformProvider();

            sut.Should().BeAssignableTo<IPlatformProvider>();
        }
    }
}