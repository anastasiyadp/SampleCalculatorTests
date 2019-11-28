using OpenQA.Selenium.Appium;

namespace SampleCalculatorTests
{
    static class Settings
    {
        static public AppiumOptions Init()
        {
            AppiumOptions apOpt = new AppiumOptions();
            apOpt.AddAdditionalCapability("deviceName", "Nokia 5");
            apOpt.AddAdditionalCapability("platformVersion", "9.0.0");
            apOpt.AddAdditionalCapability("udid", "D1AGAD1811205761");
            apOpt.AddAdditionalCapability("fulReset", "True");
            apOpt.AddAdditionalCapability("platformName", "Android");
            apOpt.AddAdditionalCapability("appPackage", "com.vbanthia.androidsampleapp");
            apOpt.AddAdditionalCapability("appActivity", ".MainActivity");
            return apOpt;
        }
    }
}
