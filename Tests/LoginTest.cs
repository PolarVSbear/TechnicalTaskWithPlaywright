using Allure.NUnit;
using Core;

namespace Tests
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test]
        public async Task Test()
        {
            await LoginPageService.NavigatePage();
            await LoginPageService.GoToMyAccount();
            await LoginPageService.FillMyAccount();
            Assert.That(await LoginPageService.IsHeaderNotNull(), Is.True, "The header is empty.");
        }
    }
}
