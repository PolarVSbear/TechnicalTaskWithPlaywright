using Allure.NUnit;

namespace Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    [AllureNUnit]
    public class LoginTest : BaseTest
    {
        [Test, Timeout(60000)]
        public async Task Test()
        {
            await MainPage.NavigatePage();
            await MainPage.FillMyAccount();
            Assert.IsTrue(await MainPage.IsMyAccountHeaderContains());
        }
    }
}
