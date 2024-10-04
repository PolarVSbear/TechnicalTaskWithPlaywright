using Core;
using Microsoft.Playwright;

namespace Tests
{
    public class BaseTest
    {
        private IBrowser Driver;
        protected MainPage MainPage;

        [SetUp]
        public async Task Setup()
        {
            Driver = await BrowserFactory.BrowserInstance.LaunchBrowserAsync();
            var page = await Driver.NewPageAsync();
            MainPage = new MainPage(page);
        }

        [TearDown]
        public async Task TearDown()
        {
            await Driver.CloseAsync();
            await BrowserFactory.BrowserInstance.CloseBrowserAsync();
        }
    }
}
