using System;
using System.Collections.Generic;
using System.Linq;

namespace Newbe.Mahua.OutputSenders.HttpApi
{
    public class FactoryHandler : IOutputSenderFactoryHandler
    {
        private readonly HttpApiOutputSender.Factory _factory;

        private static readonly TimeSpan DefaultTimeOut = TimeSpan.FromSeconds(2);

        public FactoryHandler(
            HttpApiOutputSender.Factory factory)
        {
            _factory = factory;
        }

        public IOutputSender Create(MahuaOutputConfig config)
        {
            var httpApiConfig = new HttpApiConfig
            {
                Url = config.Args["url"].ToString(),
                Urls = (config.Args.TryGetValue("urls", out var urls) ? urls as IEnumerable<string> : null)
                    ?.ToArray(),
                Timeout = config.Args.TryGetValue("timeout", out var timeOut)
                    ? TimeSpan.TryParse(timeOut.ToString(), out var timeSpan) ? timeSpan : DefaultTimeOut
                    : DefaultTimeOut,
            };
            var re = _factory(httpApiConfig);
            return re;
        }
    }
}