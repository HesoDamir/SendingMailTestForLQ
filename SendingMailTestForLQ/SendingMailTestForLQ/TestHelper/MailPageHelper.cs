using SendingMailTestForLQ.Extensions;
using SendingMailTestForLQ.Pages;

namespace SendingMailTestForLQ.TestHelper
{
    public class MailPageHelper
    {
        private MailPage MailPage = new MailPage();

        public MailPageHelper SendMail(string shippingAddress, string subject, string textOfMail)
        {
            BaseObject.InitPage(MailPage);
            MailPage.
                ClickWriteMailButton().
                TypeShippingAddress(shippingAddress).
                TypeSubject(subject).
                TypeTextOfMail(textOfMail);
            return this;
        }
    }
}
