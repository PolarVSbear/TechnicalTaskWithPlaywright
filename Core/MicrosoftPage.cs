using Microsoft.Playwright;

namespace Core
{
    public class MicrosoftPage : BasePage
    {
        private string headerLocator = "//div[@id='bodyContent']/h1";
        public string dropDownItem = "Microsoft";
        protected string dropDown = "select[name='manufacturers_id']";

        public ILocator HeaderLocator => Page.Locator(headerLocator);
        public ILocator DropDown => Page.Locator(dropDown);

        public MicrosoftPage(IPage page) : base(page)
        {
        }
    }
}
