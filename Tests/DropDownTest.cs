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
            string selectedManufacturer = "Microsoft";
            await _page.SelectOptionAsync("select[name='manufacturers_id']", selectedManufacturer);

            var h1Text = await _page.InnerTextAsync("//div[@id='bodyContent']/h1");
            StringAssert.Contains(selectedManufacturer, h1Text);
        }

        [TearDown]
        public async Task TearDown()
        {
            await _browser.CloseAsync();
        }
    }
}
