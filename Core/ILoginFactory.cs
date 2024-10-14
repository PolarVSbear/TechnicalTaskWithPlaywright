using Microsoft.Playwright;

namespace Core
{
    public interface ILoginFactory
    {
        public static ILoginFactory? Instance { get; }
        LoginPageService CreateLoginPageService(IPage page);
    }
}
