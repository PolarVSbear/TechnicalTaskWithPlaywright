using Microsoft.Playwright;

namespace Core
{
    public interface ILoginFactory
    {
        public static LoginFactory? Instance { get; }
        LoginPageService CreateLoginPageService(IPage page);
    }
}
