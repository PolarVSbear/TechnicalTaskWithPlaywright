using Microsoft.Playwright;

namespace Core
{
    public class LoginPageService : LoginPage, ILoginPage
    {
        public LoginPageService(IPage page) : base(page)
        {
        }

        public async Task GoToMyAccount()
        {
            await MyAccountLocator.ClickAsync();
        }

        private async Task<string> AssignHeaderText()
        {
            return await HeaderLocator.InnerTextAsync();
        }

        public async Task FillMyAccount()
        {
            await EmailLocator.FillAsync(email);
            await PassLocator.FillAsync(password);
            await SignInLocator.ClickAsync();
        }

        public async Task<bool> IsHeaderNotNull()
        {
            var headerText = await AssignHeaderText();
            return !string.IsNullOrEmpty(headerText);
        }
    }
}
