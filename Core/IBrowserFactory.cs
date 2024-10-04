using Microsoft.Playwright;

namespace Core
{
    public interface IBrowserFactory
    {
        public Task<IBrowser> LaunchBrowserAsync(bool headless = true);

        public Task CloseBrowserAsync();
    }
}
