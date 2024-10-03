using Microsoft.Playwright;

namespace Core
{
    public class LoginPage : MainPage, ILoginPage
    {
        private string email = "bpb@bpb.com";
        private string password = "bpb";
        private string headerLocator = "//div[@id='bodyContent']/h1";
        private string emailLocator = "[name='email_address']";
        private string passLocator = "[name='password']";
        private string signInLocator = "#tdb5";

        public LoginPage(IPage page) : base(page)
        {
        }

        private async Task<string> AssignHeaderText()
        {
            await Page.WaitForSelectorAsync(headerLocator);
            return await Page.InnerTextAsync(headerLocator);
        }

        public async Task FillMyAccount()
        {
            await Page.FillAsync(emailLocator, email);
            await Page.FillAsync(passLocator, password);
            await Page.ClickAsync(signInLocator);
        }

        public async Task<bool> IsHeaderNotNull()
        {
            var headerText = await AssignHeaderText();
            return !string.IsNullOrEmpty(headerText);
        }
    }
}
