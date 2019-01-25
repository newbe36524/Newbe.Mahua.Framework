namespace Newbe.Mahua.OutputSenders.HttpApi
{
    public class FactoryHandler : IOutputSenderFactoryHandler
    {
        private readonly HttpApiOutputSender.Factory _factory;

        public FactoryHandler(
            HttpApiOutputSender.Factory factory)
        {
            _factory = factory;
        }

        public IOutputSender Create(MahuaOutputConfig config)
        {
            var httpApiConfig = new HttpApiConfig
            {
                Url = config.Args["url"].ToString()
            };
            var re = _factory(httpApiConfig);
            return re;
        }
    }
}