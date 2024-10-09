using Microsoft.Playwright;

namespace Core
{
    public class BasePage
    {
        protected IPage Page;
        protected string address = "https://practice.bpbonline.com/";

        public BasePage(IPage page)
        {
            Page = page;
        }

        public async Task NavigatePage()
        {
            await Page.GotoAsync(address);
        }
    }
}
