using Microsoft.Playwright;

namespace Core
{
    public interface IMicrosoftFactory
    {
        public static MicrosoftFactory? Instance { get; }
        MicrosoftPageService CreateMicrosoftPageService(IPage page);
    }
}
