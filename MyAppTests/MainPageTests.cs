using System.Linq;
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
        public void TapOneTime()
        {
            App.Tap("IncrementButton");

            App.Screenshot("Tapped 1 time");

            var button = App.Query(q => q.Button("IncrementButton"))
                .FirstOrDefault();

            Assert.That(button, Is.Not.Null);

            // Caption gets mapped to Label for iOS, Text for Android
            if (Platform == Platform.iOS)
            {
                Assert.That(button.Label, Is.EqualTo("Clicked 1 time"));
            }
            else
            {
                Assert.That(button.Text, Is.EqualTo("Clicked 1 time"));
            }
        }

        [Test]
        public void TapTwoTimes()
        {
            App.Tap("IncrementButton");

            App.Screenshot("Tapped 1 time");

            App.Tap("IncrementButton");

            App.Screenshot("Tapped 2 times");

            var button = App.Query(q => q.Button("IncrementButton"))
                .FirstOrDefault();

            Assert.That(button, Is.Not.Null);

            // Caption gets mapped to Label for iOS, Text for Android
            if (Platform == Platform.iOS)
            {
                Assert.That(button.Label, Is.EqualTo("Clicked 2 times"));
            }
            else
            {
                Assert.That(button.Text, Is.EqualTo("Clicked 2 times"));
            }
        }
    }
}

