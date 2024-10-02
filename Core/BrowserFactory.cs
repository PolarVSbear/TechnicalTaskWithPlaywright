using Microsoft.Playwright;

namespace Core
{
    public static class BrowserFactory
    {
        private static IBrowser? _browser;

        public static async Task<IBrowser> LaunchBrowserAsync(bool headless = true)
        {
            if (_browser != null)
            {
                return _browser;
            }

            var playwright = await Playwright.CreateAsync();
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });

            return _browser;
        }

        public static async Task CloseBrowserAsync()
        {
            if (_browser != null)
            {
                await _browser.CloseAsync();
                _browser = null;
            }
        }
    }
}
