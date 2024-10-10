namespace Core
{
    public interface ILoginPage
    {
        public Task GoToMyAccount();
        public Task FillMyAccount();
        public Task<bool> IsHeaderNotNull();
    }
}
