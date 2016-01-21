using FluentAssertions;
using NUnit.Framework;

namespace Caliburn.Micro.TestingHelpers
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class CaliburnTestExtensions_Should
    {
        [Test]
        public void Temporarily_Replace_Platform_Provider()
        {
            var current = PlatformProvider.Current;
            var screen = new Screen();

            screen.TestWithPlatformProvider<Screen>((x) => { }, (y) => { PlatformProvider.Current.Should().NotBe(current); });

            PlatformProvider.Current.Should().Be(current);
        }
    }
}