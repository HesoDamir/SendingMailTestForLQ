using NUnit.Framework;
using SendingMailTestForLQ.Extensions;
using SendingMailTestForLQ.TestHelper;

namespace SendingMailTestForLQ.Tests
{
    [TestFixture] 
    public class LoginTests : BaseTest
    {
        private static LoginPageHelper LoginPageHelper = new LoginPageHelper();
        private static MailPageHelper MailPageHelper = new MailPageHelper();

        [Test] 
        public static void LoginOnMail()
        {
            string email = "test.account.damir@mail.ru";
            string password = "q123123a";
 
            LoginPageHelper.
                DoLogin(email, password);
        }


        [Test]
        public static void SandingMail()
        {
            string shippingAddress = "test.qds.27@mail.ru";
            string subject = "Same subject";
            string textOfMail = "Same textOfMail";
            MailPageHelper.
                SendMail(shippingAddress, subject, textOfMail);
        }
    }
}
