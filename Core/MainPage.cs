using Microsoft.Playwright;

namespace Core
{
    public class MainPage
    {
        protected IPage Page;
        protected string address = "https://practice.bpbonline.com/";
        protected string dropDown = "select[name='manufacturers_id']";
        protected string dropDownItem = "Microsoft";
        private string myAccountLocator = "text='My Account'";

        public MainPage(IPage page)
        {
            Page = page;
        }

        public async Task NavigatePage(PageType pageType)
        {
            await Page.GotoAsync(address);
        }

        public async Task<IMicrosoftPage> SelectDropDownItem()
        {
            await Page.SelectOptionAsync(dropDown, dropDownItem);
            return new MicrosoftPage(Page);
        }

        public async Task<ILoginPage> GoToMyAccount()
        {
            await Page.ClickAsync(myAccountLocator);
            return new LoginPage(Page);
        }
    }
}
