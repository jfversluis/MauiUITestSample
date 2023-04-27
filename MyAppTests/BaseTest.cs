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
        protected readonly Platform Platform;

        protected BaseTest(Platform platform) => Platform = platform;

        protected IApp App => _app ?? throw new NullReferenceException();

        [SetUp]
        public virtual void BeforeEachTest()
        {
            _app = AppInitializer.StartApp(Platform);

            App.Screenshot("App Initialized");
        }
    }
}
