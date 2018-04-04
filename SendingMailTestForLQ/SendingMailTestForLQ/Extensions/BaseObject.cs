using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SendingMailTestForLQ.Extensions
{
    public class BaseObject
    {
        public static IWebDriver driver;
        public static string baseUrl = "https://mail.ru/";

        public static void InitPage<T>(T pageClass) where T : BaseObject
        {
            PageFactory.InitElements(driver, pageClass);
        }
    }
}

