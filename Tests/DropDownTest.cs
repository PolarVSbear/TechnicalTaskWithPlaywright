using Core;

namespace Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class DropDownTest : BaseTest
    {
        [Test]
        public async Task Test()
        {
            await MainPage.NavigatePage();
            await MainPage.SelectDropDownItem();
            Assert.IsTrue(await MainPage.IsHeaderContains());
        }
    }
}
