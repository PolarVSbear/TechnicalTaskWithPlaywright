using Allure.NUnit;
using Core;

namespace Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    [AllureNUnit]
    public class LoginTest : BaseTest
    {
        [Test]
        public async Task Test()
        {
            await MainPage.NavigatePage();
            var loginPage = await MainPage.GoToMyAccount();
            await loginPage.FillMyAccount();
            Assert.IsTrue(await loginPage.IsHeaderNotNull());
        }
    }
}
