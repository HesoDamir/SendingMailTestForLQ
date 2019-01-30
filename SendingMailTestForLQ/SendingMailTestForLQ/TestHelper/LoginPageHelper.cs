using SendingMailTestForLQ.Extensions;
using SendingMailTestForLQ.Pages;

namespace SendingMailTestForLQ.TestHelper
{
    public class LoginPageHelper
    {
        private LoginPage loginPage = new LoginPage();

        public LoginPageHelper DoLogin(string email, string password)
        {
            BaseObject.InitPage(loginPage);
            loginPage.
                TypeEmail(email).
                TypePassword(password).
                ClickSignInButton();
            return this;
        }
    }
}
