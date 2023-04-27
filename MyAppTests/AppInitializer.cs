using Xamarin.UITest;

namespace MyAppTests
{
    static class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            switch (platform)
            {
                case Platform.Android:
                    return ConfigureApp
                                .Android
                                .ApkFile("../../../../MauiUITestSample/bin/Debug/net7.0-android/com.companyname.mauiuitestsample.apk")
                                .StartApp(Xamarin.UITest.Configuration.AppDataMode.Clear);

                case Platform.iOS:
                    return ConfigureApp
                                .iOS
                                //.InstalledApp("com.companyname.mauiuitestsample")
                                .AppBundle("../../../../MauiUITestSample/bin/Debug/net7.0-ios/iossimulator-x64/MauiUITestSample.app")
                                .StartApp(Xamarin.UITest.Configuration.AppDataMode.Clear);

                default:
                    throw new System.NotSupportedException();
            };
        }
    }
}
