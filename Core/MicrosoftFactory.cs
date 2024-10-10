using Microsoft.Playwright;

namespace Core
{
    public class MicrosoftFactory : IMicrosoftFactory
    {
        private static MicrosoftFactory _instance = new MicrosoftFactory();
        private MicrosoftFactory() { }
        public static MicrosoftFactory Instance { get { return _instance; } }

        public MicrosoftPageService CreateMicrosoftPageService(IPage page)
        {
            return new MicrosoftPageService(page);
        }
    }
}
