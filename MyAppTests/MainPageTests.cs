using NUnit.Framework;
using Xamarin.UITest;

namespace MyAppTests
{
	public class MainPageTests : BaseTest
	{
        public MainPageTests(Platform platform)
            : base(platform)
        {

        }

        [Test]
        public void Test1()
        {
            App.Tap("IncrementButton");
            Assert.Pass();
        }
    }
}

