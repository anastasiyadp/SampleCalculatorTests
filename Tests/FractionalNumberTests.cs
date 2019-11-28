using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SampleCalculatorTests.PageObjects;
using System;

namespace SampleCalculatorTests.Tests
{
    class FractionalNumberTests
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
            string result = calcPage.Addition("7.567", "0.1");
            Assert.AreEqual("7,57 + 0,10 = 7,67", result);
        }


        [Test]
        public void TestSubtraction()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Subtraction("11.00054", "0.00052");
            Assert.AreEqual("11,00 - 0,00 = 11,00", result);
        }

        [Test]
        public void TestMultiplication()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Multiplication("300.63", "0.56");
            Assert.AreEqual("300,63 * 0,56 = 168,35", result);
        }

        [Test]
        public void TestDivision()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Division("60", "0.2");
            Assert.AreEqual("60,00 / 0,20 = 300,00", result);
        }


        [TearDown]
        public void closeDriver()
        {
            driver.Quit();
        }
    }
}
