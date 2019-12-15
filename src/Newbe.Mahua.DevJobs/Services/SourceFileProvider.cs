namespace Newbe.Mahua.NativeApiClassfy.Services
{
    public class SourceFileProvider : ISourceFileProvider
    {
        private readonly string _basePath;

        public SourceFileProvider(
            string basePath)
        {
            _basePath = basePath;
        }

        public string GetBasePath()
        {
            return _basePath;
        }
    }
}