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
            //await MainPage.NavigatePage();
            //await BasePage.NavigatePage();
            await LoginPageService.NavigatePage();
            await LoginPageService.GoToMyAccount();
            await LoginPageService.FillMyAccount();

            //var loginPage = await MainPage.GoToMyAccount();
            //var loginPage = await LoginPageService.GoToMyAccount();
            //await loginPage.FillMyAccount();
            //Assert.IsTrue(await loginPage.IsHeaderNotNull());
            Assert.IsTrue(await LoginPageService.IsHeaderNotNull());
        }
    }
}
