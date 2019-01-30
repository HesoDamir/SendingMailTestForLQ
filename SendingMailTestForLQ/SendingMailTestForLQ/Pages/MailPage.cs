using SendingMailTestForLQ.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SendingMailTestForLQ.Pages
{
    public class MailPage : BaseObject
    {
        [FindsBy(How = How.XPath, Using = "//span[@class='b-toolbar__btn__text b-toolbar__btn__text_pad']")]
        public IWebElement writeMailButton;

        [FindsBy(How = How.XPath, Using = "//textarea[@data-original-name='To']")]
        public IWebElement typeShippingAddress;

        [FindsBy(How = How.XPath, Using = "//input[@name='Subject']")]
        public IWebElement typeSubject;

        [FindsBy(How = How.XPath, Using = "//iframe[@title='{#aria.rich_text_area}']")]
        public IWebElement getFrame;

        [FindsBy(How = How.XPath, Using = "//body[@id='tinymce']")]
        public IWebElement typeTextOfMail;

        [FindsBy(How = How.XPath, Using = "//div[@data-name='send']")]
        public IWebElement submitButton;



        public static MailPage GetMailPage()
        {
            MailPage MailPage = new MailPage();
            InitPage(MailPage);
            return MailPage;
        }

        public MailPage ClickWriteMailButton()
        {
            ExtensionMethods.WaitShowElement(driver, writeMailButton);
            writeMailButton.Click();
            return GetMailPage();
        }

        public MailPage TypeShippingAddress(string shippingAddress)
        {
            ExtensionMethods.WaitShowElement(driver, typeShippingAddress);
            typeShippingAddress.Clear();
            typeShippingAddress.SendKeys(shippingAddress);
            return GetMailPage();
        }

        public MailPage TypeSubject(string subject)
        {
            typeSubject.Clear();
            typeSubject.SendKeys(subject);
            return GetMailPage();
        }
        public MailPage TypeTextOfMail(string textOfMail)
        {
            ExtensionMethods.SwitchToFrame(driver, getFrame);
            typeTextOfMail.Clear();
            typeTextOfMail.SendKeys(textOfMail);
            ExtensionMethods.SwitchToDefaultContent(driver);
            submitButton.Click();
            return GetMailPage();
        }

    }
}

