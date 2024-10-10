using Microsoft.Playwright;

namespace Core
{
    public class LoginFactory : ILoginFactory
    {
        private static LoginFactory _instance = new LoginFactory();
        private LoginFactory()
        {
        }
        public static LoginFactory Instance
        {
            get
            {
                return _instance;
            }
        }

        public LoginPageService CreateLoginPageService(IPage page)
        {
            return new LoginPageService(page);
        }
    }
}
