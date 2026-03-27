using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace WinAppDriver.Apps
{
    public class NotepadPage
    {
        private readonly IWebDriver _driver;

        public NotepadPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement MinimizeButton()
        {
            return _driver.FindElement(MobileBy.Name("Minimizar"));
        }

        public IWebElement MaximizeButton()
        {
            return _driver.FindElement(MobileBy.Name("Maximizar"));
        }

        public IWebElement CloseButton()
        {
            return _driver.FindElement(MobileBy.Name("Fechar"));
        }

        public IWebElement MenuFile()
        {
            return _driver.FindElement(MobileBy.AccessibilityId("File"));
        }

        public IWebElement MenuEdit()
        {
            return _driver.FindElement(MobileBy.AccessibilityId("Edit"));
        }

        public IWebElement MenuView()
        {
            return _driver.FindElement(MobileBy.AccessibilityId("View"));
        }

        public IWebElement TextEditor()
        {
            return _driver.FindElement(MobileBy.Name("Editor de texto"));
        }

        public IWebElement DialogSaveButton()
        {
            return _driver.FindElement(MobileBy.Name("Salvar"));
        }

        public IWebElement DialogDontSaveButton()
        {
            return _driver.FindElement(MobileBy.Name("Não salvar"));
        }

        public IWebElement DialogCancelButton()
        {
            return _driver.FindElement(MobileBy.Name("Cancelar"));
        }
    }
}
