using Microsoft.Playwright;

namespace Tests
{
    public class DropDownTest
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IPage _page;

        [SetUp]
        public async Task Setup()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            _page = await _browser.NewPageAsync();
        }

        [Test]
        public async Task Test()
        {
            await _page.GotoAsync("https://practice.bpbonline.com/");

            await _page.SelectOptionAsync("select[name='manufacturers_id']", "Microsoft");
        }

        [TearDown]
        public async Task TearDown()
        {
            await _browser.CloseAsync();
        }
    }
}
