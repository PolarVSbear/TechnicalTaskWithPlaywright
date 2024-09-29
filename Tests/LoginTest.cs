namespace Tests
{
    [TestFixture]
    //[Parallelizable(ParallelScope.All)]
    public class LoginTest : BaseTest
    {
        [Test]
        public async Task Test()
        {
            await MainPage.NavigatePage();
            await MainPage.FillMyAccount();
            Assert.IsTrue(await MainPage.IsMyAccountHeaderContains());
        }
    }
}
