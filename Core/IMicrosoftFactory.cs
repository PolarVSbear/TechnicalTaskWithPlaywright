using Microsoft.Playwright;

namespace Core
{
    public interface IMicrosoftFactory
    {
        MicrosoftPageService CreateMicrosoftPageService(IPage page);
    }
}
