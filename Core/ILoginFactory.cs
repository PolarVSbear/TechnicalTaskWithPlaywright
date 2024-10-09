using Microsoft.Playwright;

namespace Core
{
    public interface ILoginFactory
    {
        LoginPageService CreateLoginPageService(IPage page);
    }
}
