using Microsoft.Playwright;

namespace Core
{
    public class LoginFactory : ILoginFactory
    {
        public LoginPageService CreateLoginPageService(IPage page)
        {
            return new LoginPageService(page);
        }
    }
}
