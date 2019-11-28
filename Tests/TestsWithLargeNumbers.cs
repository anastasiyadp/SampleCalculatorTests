using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SampleCalculatorTests.PageObjects;
using System;


namespace SampleCalculatorTests.Tests
{
    class TestsWithLargeNumbers
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
            string result = calcPage.Addition("1", "9999999999999");
            Assert.AreEqual("1,00 + 9999999999999,00 = 10000000000000,00", result);
        }


        [Test]
        public void TestSubtraction()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Subtraction("123456789", "10");
            Assert.AreEqual("123456789,00 - 10,00 = 123456779,00", result);
        }

        [Test]
        public void TestMultiplication()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Multiplication("2000000000555", "3.5");
            Assert.AreEqual("2000000000555.00 * 3,50 = 7000000001942.00", result);
        }

        [Test]
        public void TestDivision()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Division("1000000000500", "2.0");
            Assert.AreEqual("1000000000500,00 / 2,00 = 500000000250,00", result);
        }


        [TearDown]
        public void closeDriver()
        {
            driver.Quit();
        }
    }
}
