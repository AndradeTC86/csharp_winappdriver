using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using WinAppDriver.Apps;
using System;

namespace WinAppDriver.Tests
{
    public class CalculatorTest
    {
        private WindowsDriver<WindowsElement> _calcSession;
        private CalcPage _calc;

        [SetUp]
        public void Setup()
        {
            var options = new AppiumOptions();
            options.PlatformName = "Windows";
            options.AddAdditionalCapability("appium:automationName", "Windows");
            options.AddAdditionalCapability("appium:deviceName", "WindowsPC");
            options.AddAdditionalCapability("appium:app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");

            _calcSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            _calc = new CalcPage(_calcSession);
        }

        [TearDown]
        public void TearDown()
        {
            if (_calcSession != null)
            {
                _calcSession.Quit();
                _calcSession.Dispose();
            }
        }

        [Test]
        public void TestAddition()
        {
            _calc.GetNumButton("1").Click();
            _calc.GetOperatorButton("plus").Click();
            _calc.GetNumButton("7").Click();
            _calc.GetOperatorButton("equal").Click();

            Assert.That(_calc.GetDisplayResults(), Is.EqualTo("8"));
        }

        [Test]
        public void TestSubtraction()
        {
            _calc.GetNumButton("9").Click();
            _calc.GetOperatorButton("minus").Click();
            _calc.GetNumButton("1").Click();
            _calc.GetOperatorButton("equal").Click();

            Assert.That(_calc.GetDisplayResults(), Is.EqualTo("8"));
        }

        [Test]
        public void TestMultiplication()
        {
            _calc.GetNumButton("8").Click();
            _calc.GetOperatorButton("multiply").Click();
            _calc.GetNumButton("4").Click();
            _calc.GetOperatorButton("equal").Click();

            Assert.That(_calc.GetDisplayResults(), Is.EqualTo("32"));
        }

        [Test]
        public void TestDivision()
        {
            _calc.GetNumButton("8").Click();
            _calc.GetOperatorButton("divide").Click();
            _calc.GetNumButton("4").Click();
            _calc.GetOperatorButton("equal").Click();

            Assert.That(_calc.GetDisplayResults(), Is.EqualTo("2"));
        }
    }
}
