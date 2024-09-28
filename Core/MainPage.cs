using Microsoft.Playwright;

namespace Core
{
    public class MainPage
    {
        protected IPage Page;
        string address = "https://practice.bpbonline.com/";
        string dropDownItem = "Microsoft";
        private string headerLocator = "//div[@id='bodyContent']/h1";
        private string myAccountHeader = "My Account Information";

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
            return await Page.InnerTextAsync(headerLocator);
        }

        public async Task<bool> IsHeaderContains()
        {
            var headerText = await AssignHeaderText();
            return headerText.Contains(dropDownItem, StringComparison.OrdinalIgnoreCase);
        }

        public async Task FillMyAccount()
        {
            await Page.ClickAsync("text='My Account'");
            await Page.FillAsync("[name='email_address']", "bpb@bpb.com");
            await Page.FillAsync("[name='password']", "bpb@123");
            await Page.ClickAsync("#tdb5");
        }

        public async Task<bool> IsMyAccountHeaderContains()
        {
            var headerText = await AssignHeaderText();
            return headerText.Contains(myAccountHeader, StringComparison.OrdinalIgnoreCase);
        }
    }
}
