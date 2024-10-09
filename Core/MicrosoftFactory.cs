using Microsoft.Playwright;

namespace Core
{
    public class MicrosoftFactory : IMicrosoftFactory
    {
        public MicrosoftPageService CreateMicrosoftPageService(IPage page)
        {
            return new MicrosoftPageService(page);
        }
    }
}
