using Microsoft.Playwright;

namespace Core
{
    public class MicrosoftPageService : MicrosoftPage, IMicrosoftPage
    {
        public MicrosoftPageService(IPage page) : base(page)
        {
        }

        public async Task SelectDropDownItem()
        {
            await DropDown.SelectOptionAsync(dropDownItem);
        }

        private async Task<string> AssignHeaderText()
        {
            return await HeaderLocator.InnerTextAsync();
        }

        public async Task<bool> IsHeaderContains()
        {
            var headerText = await AssignHeaderText();
            return headerText.Contains(dropDownItem, StringComparison.OrdinalIgnoreCase);
        }
    }
}
