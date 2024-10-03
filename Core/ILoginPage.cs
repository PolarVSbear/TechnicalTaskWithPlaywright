namespace Core
{
    public interface ILoginPage
    {
        public Task FillMyAccount();
        public Task<bool> IsHeaderNotNull();
    }
}
