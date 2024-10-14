using Microsoft.Playwright;

namespace Core
{
    public class MicrosoftFactory : IMicrosoftFactory
    {
        private static IMicrosoftFactory _instance = new MicrosoftFactory();
        private MicrosoftFactory() { }
        public static IMicrosoftFactory Instance { get { return _instance; } }

        public MicrosoftPageService CreateMicrosoftPageService(IPage page)
        {
            return new MicrosoftPageService(page);
        }
    }
}
