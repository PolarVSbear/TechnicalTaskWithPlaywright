using Microsoft.Playwright;

namespace Core
{
    public class MicrosoftPage : MainPage, IMicrosoftPage
    {
        private string headerLocator = "//div[@id='bodyContent']/h1";

        public MicrosoftPage(IPage page) : base(page)
        {
        }

        private async Task<string> AssignHeaderText()
        {
            await Page.WaitForSelectorAsync(headerLocator);
            return await Page.InnerTextAsync(headerLocator);
        }

        public async Task<bool> IsHeaderContains()
        {
            var headerText = await AssignHeaderText();
            return headerText.Contains(dropDownItem, StringComparison.OrdinalIgnoreCase);
        }
    }
}
