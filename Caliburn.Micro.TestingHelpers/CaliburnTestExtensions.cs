using System;
using System.Diagnostics.CodeAnalysis;
using Caliburn.Micro;

namespace Caliburn.Micro.TestingHelpers
{
    [ExcludeFromCodeCoverage]
    public static class CaliburnTestExtensions
    {
        public static void TestWithPlatformProvider<TSubject>(
            this TSubject subject,
            Action<TestablePlatformProvider> arrange,
            Action<TSubject> act)
            where TSubject : IScreen
        {
            // how to test TryClose, cf.: https://caliburnmicro.codeplex.com/discussions/254944
            // however you definitively need to override the PlatformProvider (at least since Caliburn 1.5 or 2.x)
            var platformProvider = new TestablePlatformProvider();

            arrange(platformProvider);

            var currentProvider = PlatformProvider.Current;
            PlatformProvider.Current = platformProvider;
            try { act(subject); }
            finally { PlatformProvider.Current = currentProvider; }
        }
    }
}
