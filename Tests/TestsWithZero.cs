using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SampleCalculatorTests.PageObjects;
using System;

namespace SampleCalculatorTests.Tests
{
    class TestsWithZero
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
            string result = calcPage.Addition("2", "0");
            Assert.AreEqual("2,00 + 0,00 = 2,00", result);
        }


        [Test]
        public void TestSubtraction()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Subtraction("0", "3");
            Assert.AreEqual("0,00 - 3,00 = -3,00", result);
        }

        [Test]
        public void TestDivisionFirstValueZero()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Division("0", "22");
            Assert.AreEqual("0,00 / 22,00 = 0,00", result);
        }

        [Test]
        public void TestDivisionSecondValueZero()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Division("14", "0");
            Assert.AreEqual("Сannot divide by zero", result);
        }

        [Test]
        public void TestDivisionTwoValueZero()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Division("0", "0");
            Assert.AreEqual("Сannot divide by zero", result);
        }

        [Test]
        public void TestMultiplication()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Multiplication("4", "0");
            Assert.AreEqual("4,00 * 0,00 = 0,00", result);
        }

        [Test]
        public void TestMultiplicationTwoValueZero()
        {
            CalcPage calcPage = new CalcPage(driver);
            string result = calcPage.Multiplication("0", "0");
            Assert.AreEqual("0,00 * 0,00 = 0,00", result);
        }

        [TearDown]
        public void closeDriver()
        {
            driver.Quit();
        }
    }
}
