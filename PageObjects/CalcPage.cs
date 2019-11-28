using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;

namespace SampleCalculatorTests.PageObjects
{
    class CalcPage
    {
        private AppiumDriver<AndroidElement> driver;

        public CalcPage(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public AndroidElement firstField => driver.FindElement(By.Id("inputFieldLeft"));
        public AndroidElement secondField => driver.FindElement(By.Id("inputFieldRight"));
        public AndroidElement addButton => driver.FindElement(By.Id("additionButton"));
        public AndroidElement subButton=> driver.FindElement(By.Id("subtractButton"));
        public AndroidElement multButton => driver.FindElement(By.Id("multiplicationButton"));
        public AndroidElement divButton => driver.FindElement(By.Id("divisionButton"));
        public AndroidElement resetButton => driver.FindElement(By.Id("resetButton"));
        public AndroidElement resultText => driver.FindElement(By.Id("resultTextView"));

        public string Addition(string firstValue, string secondValue)
        {
            firstField.SendKeys(firstValue);
            secondField.SendKeys(secondValue);
            addButton.Click();
            return driver.FindElementByClassName("android.widget.TextView").Text;
        }

        public string Subtraction(string firstValue, string secondValue)
        {
            firstField.SendKeys(firstValue);
            secondField.SendKeys(secondValue);
            subButton.Click();
            return driver.FindElementByClassName("android.widget.TextView").Text;
        }
        public string Multiplication(string firstValue, string secondValue)
        {
            firstField.SendKeys(firstValue);
            secondField.SendKeys(secondValue);
            multButton.Click();
            return driver.FindElementByClassName("android.widget.TextView").Text;
        }
        public string Division(string firstValue, string secondValue)
        {
            firstField.SendKeys(firstValue);
            secondField.SendKeys(secondValue);
            divButton.Click();
            return driver.FindElementByClassName("android.widget.TextView").Text;
        }

        public void FillFields(string firstValue, string secondValue)
        {
            firstField.SendKeys(firstValue);
            secondField.SendKeys(secondValue);
        }

    }
}
