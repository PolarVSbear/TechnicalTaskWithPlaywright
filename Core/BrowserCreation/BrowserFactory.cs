using Microsoft.Playwright;

namespace Core.BrowserCreation
{
    public class BrowserFactory : IBrowserFactory
    {
        private static IBrowser? _browser;

        private static BrowserFactory _browserInstance = new BrowserFactory();
        private static readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1, 1);

        private BrowserFactory() { }

        public static IBrowserFactory BrowserInstance
        {
            get { return _browserInstance; }
        }

        public async Task<IBrowser> LaunchBrowserAsync(bool headless = true)
        {
            await _semaphoreSlim.WaitAsync();
            try
            {
                var playwright = await Playwright.CreateAsync();
                _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = headless });
                return _browser;
            }
            finally
            {
                _semaphoreSlim?.Release();
            }
        }

        public async Task CloseBrowserAsync()
        {
            await _semaphoreSlim.WaitAsync();
            try
            {
                await _browser.CloseAsync();
            }
            finally
            {
                _semaphoreSlim.Release();
            }
        }
    }
}
