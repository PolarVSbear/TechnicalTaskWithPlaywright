using Allure.NUnit;
using Core;

namespace Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    [AllureNUnit]
    public class DropDownTest : BaseTest
    {
        [Test]
        public async Task Test()
        {
            await MainPage.NavigatePage();
            var microsoftPage = await MainPage.SelectDropDownItem();
            Assert.IsTrue(await microsoftPage.IsHeaderContains());
        }
    }
}
