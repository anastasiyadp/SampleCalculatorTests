using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using SampleCalculatorTests.PageObjects;

namespace SampleCalculatorTests.Tests
{
    public class IntegerTest
    {
        AppiumDriver<AndroidElement> driver;

        [SetUp]
        public void InitDriver()
        {
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), Settings.Init());
        }


        [Test]
        public void TestAddition()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Addition("4", "2");
            Assert.AreEqual("4,00 + 2,00 = 6,00", result);
        }


        [Test]
        public void TestSubtraction()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Subtraction("6","1");
            Assert.AreEqual("6,00 - 1,00 = 5,00", result);
        }

        [Test]
        public void TestDivision()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Division("459", "3");
            Assert.AreEqual("459,00 / 3,00 = 153,00", result);
        }

        [Test]
        public void TestMultiplication()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Multiplication("14", "2");
            Assert.AreEqual("14,00 * 2,00 = 28,00", result);
        }

       
        [TearDown]
        public void closeDriver()
        {
            driver.Quit();
        }
    }
}
