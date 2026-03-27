using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using WinAppDriver.Apps;
using System;

namespace WinAppDriver.Tests
{
    public class NotepadTest
    {
        private WindowsDriver<WindowsElement> _notepadSession;
        private NotepadPage _notepad;

        [SetUp]
        public void Setup()
        {
            var options = new AppiumOptions();
            options.PlatformName = "Windows";
            options.AddAdditionalCapability("appium:automationName", "Windows");
            options.AddAdditionalCapability("appium:deviceName", "WindowsPC");
            options.AddAdditionalCapability("appium:app", @"C:\Windows\System32\notepad.exe");

            _notepadSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            _notepad = new NotepadPage(_notepadSession);
        }

        [TearDown]
        public void TearDown()
        {
            if (_notepadSession != null)
            {
                _notepadSession.Quit();
                _notepadSession.Dispose();
            }
        }

        [Test]
        public void TestNoteCreation()
        {
            _notepad.TextEditor().SendKeys(Keys.Control + "a");
            _notepad.TextEditor().SendKeys(Keys.Delete);

            // Mandando devagar ajuda a nao perder teclas
            var textToSend = "Test Automation with WinAppDriver";

            _notepad.TextEditor().SendKeys(textToSend);


            // Remover o caractere extra \r que pode vir no fim do texto do RichEdit
            string text = _notepad.TextEditor().Text.TrimEnd('\r', '\n', '\0');

            Assert.That(text, Is.EqualTo(textToSend));

            _notepad.TextEditor().SendKeys(Keys.Control + "w");
            _notepad.DialogCancelButton().Click();

            text = _notepad.TextEditor().Text.TrimEnd('\r', '\n', '\0');
            Assert.That(text, Is.EqualTo(textToSend));

            _notepad.TextEditor().SendKeys(Keys.Control + "w");
            _notepad.DialogDontSaveButton().Click();
        }
    }
}
