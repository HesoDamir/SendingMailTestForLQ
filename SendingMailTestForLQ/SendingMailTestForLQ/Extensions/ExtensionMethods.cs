using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SendingMailTestForLQ.Extensions
{
    class ExtensionMethods : BaseObject
    {
        public static void WaitShowElement(IWebDriver driver, IWebElement FindsBy)
        {
            WebDriverWait iWait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            iWait.Until(dr => FindsBy.Displayed);
        }
        public static void SwitchToFrame(IWebDriver driver, IWebElement FindsBy)
        {
            driver.SwitchTo().DefaultContent().SwitchTo().Frame(FindsBy);
        }
        public static void SwitchToDefaultContent(IWebDriver driver)
        {
            driver.SwitchTo().DefaultContent();
        }
    }
}
