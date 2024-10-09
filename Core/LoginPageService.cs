using Microsoft.Playwright;

namespace Core
{
    public class LoginPageService : BasePage, ILoginPage
    {
        private readonly LoginPage _loginPage;

        public LoginPageService(IPage page) : base(page)
        {
            _loginPage = new LoginPage(page);
        }

        public async Task GoToMyAccount()
        {
            await _loginPage.MyAccountLocator.ClickAsync();
        }

        private async Task<string> AssignHeaderText()
        {
            return await _loginPage.HeaderLocator.InnerTextAsync();
        }

        public async Task FillMyAccount()
        {
            await _loginPage.EmailLocator.FillAsync(_loginPage.email);
            await _loginPage.PassLocator.FillAsync(_loginPage.password);
            await _loginPage.SignInLocator.ClickAsync();
        }

        public async Task<bool> IsHeaderNotNull()
        {
            var headerText = await AssignHeaderText();
            return !string.IsNullOrEmpty(headerText);
        }
    }
}
