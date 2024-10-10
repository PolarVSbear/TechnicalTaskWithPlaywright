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
            await LoginPageService.NavigatePage();
            await LoginPageService.GoToMyAccount();
            await LoginPageService.FillMyAccount();
            Assert.IsTrue(await LoginPageService.IsHeaderNotNull());
        }
    }
}
