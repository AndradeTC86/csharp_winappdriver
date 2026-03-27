using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace WinAppDriver.Apps
{
    public class CalcPage
    {
        private readonly IWebDriver _driver;

        public CalcPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement GetNumButton(string num)
        {
            return _driver.FindElement(MobileBy.AccessibilityId($"num{num}Button"));
        }

        public IWebElement GetOperatorButton(string op)
        {
            return _driver.FindElement(MobileBy.AccessibilityId($"{op}Button"));
        }

        public string GetDisplayResults()
        {
            string text = _driver.FindElement(MobileBy.AccessibilityId("CalculatorResults")).Text;

            // Remove a string "A exibição é" e espaços ao redor
            return text.Replace("A exibição é", "").Trim();
        }
    }
}
