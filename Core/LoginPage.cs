using Microsoft.Playwright;

namespace Core
{
    public class LoginPage : BasePage
    {
        public string email = "bpb@bpb.com";
        public string password = "bpb";
        private string headerLocator = "//div[@id='bodyContent']/h1";
        private string emailLocator = "[name='email_address']";
        private string passLocator = "[name='password']";
        private string signInLocator = "#tdb5";
        private string myAccountLocator = "//a/span[text()='My Account']";

        public ILocator HeaderLocator => Page.Locator(headerLocator);
        public ILocator EmailLocator => Page.Locator(emailLocator);
        public ILocator PassLocator => Page.Locator(passLocator);
        public ILocator SignInLocator => Page.Locator(signInLocator);
        public ILocator MyAccountLocator => Page.Locator(myAccountLocator);

        public LoginPage(IPage page) : base(page)
        {
        }
    }
}
