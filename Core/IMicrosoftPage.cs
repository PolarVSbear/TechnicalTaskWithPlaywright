namespace Core
{
    public interface IMicrosoftPage
    {
        public Task SelectDropDownItem();
        public Task<bool> IsHeaderContains();
    }
}
