using SendingMailTestForLQ.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SendingMailTestForLQ.Pages
{
    public class LoginPage : BaseObject
    {
        [FindsBy(How = How.Id, Using = "mailbox:login")]
        public IWebElement emailField;

        [FindsBy(How = How.Id, Using = "mailbox:password")]
        public IWebElement passwordField;

        [FindsBy(How = How.Id, Using = "mailbox:submit")]
        public IWebElement signInButton;

        
        public static LoginPage GetLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            InitPage(loginPage);
            return loginPage;
        }

        public LoginPage TypeEmail(string email)
        {
            emailField.Clear();
            emailField.SendKeys(email);
            return GetLoginPage();
        }

        public LoginPage TypePassword(string password)
        {
            passwordField.Clear();
            passwordField.SendKeys(password);
            return GetLoginPage();
        }

        public MailPage ClickSignInButton()
        {
            signInButton.Click();
            return MailPage.GetMailPage();
        }

    }
}

