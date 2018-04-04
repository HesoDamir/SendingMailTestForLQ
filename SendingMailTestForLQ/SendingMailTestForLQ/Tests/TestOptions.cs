using SendingMailTestForLQ.Extensions;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SendingMailTestForLQ.Tests 
{
    public class BaseTest : BaseObject
    {
        [TestFixtureSetUp] 
        public void beforeClass()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseUrl);
            driver.Manage().Window.Maximize();
        }

        //[SetUp]  
        //public void beforeTest()
        //{
        //    driver.Navigate().GoToUrl(baseUrl);
        //    driver.Manage().Window.Maximize();
        //}

        //[TearDown]
        //public void afterTest()
        //{
        //    driver.Manage().Cookies.DeleteAllCookies();;
        //}

        //[TestFixtureTearDown]
        //public void afterClass()
        //{
        //    driver.Quit();
        //}
    }
}
