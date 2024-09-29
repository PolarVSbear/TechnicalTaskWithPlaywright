using Microsoft.Playwright;

namespace Core
{
    public class MainPage
    {
        protected IPage Page;
        private string address = "https://practice.bpbonline.com/";
        private string dropDownItem = "Microsoft";
        private string myAccountHeader = "My Account Information";
        private string email = "bpb@bpb.com";
        private string password = "bpb@123";
        //private string headerLocator = "//div[@id='bodyContent']/h1";
        private string headerLocator = "//h1";
        private string myAccountLocator = "text='My Account'";
        private string emailLocator = "[name='email_address']";
        private string passLocator = "[name='password']";
        private string signInLocator = "#tdb5";

        public MainPage(IPage page)
        {
            Page = page;
        }

        public async Task NavigatePage()
        {
            await Page.GotoAsync(address);
        }

        public async Task SelectDropDownItem()
        {
            await Page.SelectOptionAsync("select[name='manufacturers_id']", dropDownItem);
        }

        private async Task<string> AssignHeaderText()
        {
            //await Page.WaitForSelectorAsync(headerLocator);
            //return await Page.InnerTextAsync(headerLocator);
            return await Page.InnerTextAsync("//h1");
        }

        public async Task<bool> IsHeaderContains()
        {
            var headerText = await AssignHeaderText();
            return headerText.Contains(dropDownItem, StringComparison.OrdinalIgnoreCase);
        }

        public async Task FillMyAccount()
        {
            await Page.ClickAsync(myAccountLocator);
            await Page.FillAsync(emailLocator, email);
            await Page.FillAsync(passLocator, password);
            await Page.ClickAsync(signInLocator);
        }

        public async Task<bool> IsMyAccountHeaderContains()
        {
            var headerText = await AssignHeaderText();
            return headerText.Contains(myAccountHeader, StringComparison.OrdinalIgnoreCase);
        }
    }
}
