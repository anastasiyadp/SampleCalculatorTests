using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using SampleCalculatorTests.PageObjects;

namespace SampleCalculatorTests.Tests
{
    class TestsResetAndResultFiled
    {
        AppiumDriver<AndroidElement> driver;

        [SetUp]
        public void InitDriver()
        {
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), Settings.Init());
        }


        [Test]
        public void TestWithEmptyOutputField()
        {
            CalcPage calcPage = new CalcPage(driver);
            calcPage.FillFields("4", "2");
            calcPage.resetButton.Click();
            string result = calcPage.resultText.Text;
            string firstField = calcPage.firstField.Text;
            string secondField = calcPage.secondField.Text;
            Assert.AreEqual("", result);
            Assert.AreEqual("", firstField);
            Assert.AreEqual("", secondField);
        }

        [Test]
        public void TestWithNotEmptyOutputField()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Subtraction("4", "2");

            calcPage.resetButton.Click();
            string firstField = calcPage.firstField.Text;
            string secondField = calcPage.secondField.Text;
            Assert.AreEqual("", result);
            Assert.AreEqual("", firstField);
            Assert.AreEqual("", secondField);
        }

        [Test]
        public void TestResultField()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Subtraction("4", "");

            calcPage.resetButton.Click();
            Assert.AreEqual("Please, fill the input fields correctly", result);
        }


        [TearDown]
        public void closeDriver()
        {
            driver.Quit();
        }
    }
}
