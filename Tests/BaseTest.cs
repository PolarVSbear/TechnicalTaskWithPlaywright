using Core;
using Core.BrowserCreation;
using Microsoft.Playwright;

namespace Tests
{
    public class BaseTest
    {
        private IBrowser Driver;
        //protected MainPage MainPage;
        //protected BasePage BasePage;
        protected LoginPageService LoginPageService;
        protected ILoginFactory LoginFactory;
        protected MicrosoftPageService MicrosoftPageService;
        protected IMicrosoftFactory MicrosoftFactory;
        

        [SetUp]
        public async Task Setup()
        {
            Driver = await BrowserFactory.BrowserInstance.LaunchBrowserAsync();
            var page = await Driver.NewPageAsync();
            //MainPage = new MainPage(page);
            //BasePage = new BasePage(page);
            LoginFactory = new LoginFactory();
            LoginPageService = LoginFactory.CreateLoginPageService(page);
            MicrosoftFactory = new MicrosoftFactory();
            MicrosoftPageService = MicrosoftFactory.CreateMicrosoftPageService(page);
        }

        [TearDown]
        public async Task TearDown()
        {
            await Driver.CloseAsync();
            await BrowserFactory.BrowserInstance.CloseBrowserAsync();
        }
    }
}
