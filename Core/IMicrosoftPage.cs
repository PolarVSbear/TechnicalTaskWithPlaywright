namespace Core
{
    public interface IMicrosoftPage
    {
        public Task<IMicrosoftPage> SelectDropDownItem();
        public Task<bool> IsHeaderContains();
    }
}
