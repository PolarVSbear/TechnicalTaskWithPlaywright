﻿using Core;
using Core.BrowserCreation;
using Microsoft.Playwright;

namespace Tests
{
    public class BaseTest
    {
        private IBrowser Driver;
        protected LoginPageService LoginPageService;
        protected static LoginFactory LoginFactory = LoginFactory.Instance;
        protected MicrosoftPageService MicrosoftPageService;
        protected static MicrosoftFactory MicrosoftFactory = MicrosoftFactory.Instance;

        [SetUp]
        public async Task Setup()
        {
            Driver = await BrowserFactory.BrowserInstance.LaunchBrowserAsync();
            var page = await Driver.NewPageAsync();
            LoginPageService = LoginFactory.CreateLoginPageService(page);
            MicrosoftPageService = MicrosoftFactory.CreateMicrosoftPageService(page);
        }

        [TearDown]
        public async Task TearDown()
        {
            await Driver.CloseAsync();
            //await BrowserFactory.BrowserInstance.CloseBrowserAsync();
        }
    }
}
