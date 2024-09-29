using Core;
using Microsoft.Playwright;

namespace Tests
{
    public class BaseTest
    {
        private IPlaywright _playwright;
        private IBrowser Driver;
        protected MainPage MainPage;

        [SetUp]
        public async Task Setup()
        {
            _playwright = await Playwright.CreateAsync();
            Driver = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            var page = await Driver.NewPageAsync();
            MainPage = new MainPage(page);
        }

        [TearDown]
        public async Task TearDown()
        {
            await Driver.CloseAsync();
        }
    }
}
