using Allure.NUnit;
using Core;

namespace Tests
{
    [TestFixture]
    public class DropDownTest : BaseTest
    {
        [Test]
        public async Task Test()
        {
            await MicrosoftPageService.NavigatePage();
            await MicrosoftPageService.SelectDropDownItem();
            Assert.That(await MicrosoftPageService.IsHeaderContains(), Is.True, "The header doesn't equal.");
        }
    }
}
