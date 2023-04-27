using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace MyAppTests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class BaseTest
    {
        IApp _app;
        readonly Platform _platform;

        protected BaseTest(Platform platform) => _platform = platform;

        protected IApp App => _app ?? throw new NullReferenceException();

        [SetUp]
        public virtual void BeforeEachTest()
        {
            _app = AppInitializer.StartApp(_platform);

            App.Screenshot("App Initialized");
        }
    }
}
