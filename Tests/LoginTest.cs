using Microsoft.Playwright;

namespace Tests
{
    [TestFixture]
    public class LoginTest
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
            await _page.ClickAsync("text='My Account'");
            await _page.FillAsync("[name='email_address']", "bpb@bpb.com");
            await _page.FillAsync("[name='password']", "bpb@123");
            await _page.ClickAsync("#tdb5");

            var h1Text = await _page.InnerTextAsync("//div[@id='bodyContent']/h1");
            StringAssert.Contains("My Account Information", h1Text);
        }

        [TearDown]
        public async Task TearDown()
        {
            await _browser.CloseAsync();
        }
    }
}
