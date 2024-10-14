using Microsoft.Playwright;

namespace Core
{
    public interface IMicrosoftFactory
    {
        public static IMicrosoftFactory? Instance { get; }
        MicrosoftPageService CreateMicrosoftPageService(IPage page);
    }
}
