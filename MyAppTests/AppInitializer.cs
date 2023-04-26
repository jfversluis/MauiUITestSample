using Xamarin.UITest;

namespace MyAppTests
{
    static class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            return platform switch
            {
                Platform.Android => ConfigureApp
                                        .Android
                                        .ApkFile("../../../../MauiUITestSample/bin/Debug/net7.0-android/com.companyname.mauiuitestsample.apk")
                                        .StartApp(Xamarin.UITest.Configuration.AppDataMode.Clear),

                Platform.iOS => ConfigureApp
                                        .iOS
                                        //.InstalledApp("com.companyname.mauiuitestsample")
                                        .AppBundle("../../../../MauiUITestSample/bin/Debug/net7.0-ios/iossimulator-x64/MauiUITestSample.app")
                                        .StartApp(Xamarin.UITest.Configuration.AppDataMode.Clear),

                _ => throw new System.NotSupportedException(),
            };
        }
    }
}
