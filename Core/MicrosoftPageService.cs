using Microsoft.Playwright;

namespace Core
{
    public class MicrosoftPageService : BasePage, IMicrosoftPage
    {
        private readonly MicrosoftPage _microsoftPage;

        public MicrosoftPageService(IPage page) : base(page)
        {
            _microsoftPage = new MicrosoftPage(page);
        }

        public async Task<IMicrosoftPage> SelectDropDownItem()
        {
            await _microsoftPage.DropDown.SelectOptionAsync(_microsoftPage.dropDownItem);
            return new MicrosoftPageService(Page);
        }

        private async Task<string> AssignHeaderText()
        {
            //await Page.WaitForSelectorAsync(headerLocator);
            return await _microsoftPage.HeaderLocator.InnerTextAsync();
            //return await Page.InnerTextAsync(headerLocator);
        }

        public async Task<bool> IsHeaderContains()
        {
            var headerText = await AssignHeaderText();
            return headerText.Contains(_microsoftPage.dropDownItem, StringComparison.OrdinalIgnoreCase);
        }
    }
}
