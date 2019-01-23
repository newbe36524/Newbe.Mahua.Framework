using System;
using Newbe.Mahua.Agents.HttpApi.Services;
using Newbe.Mahua.InputReceivers.HttpApi.Services;

namespace Newbe.Mahua.InputReceivers.HttpApi
{
    public class HttpFactoryHandler : IInputReceiverFactoryHandler
    {
        private readonly IWebHostContainer _webHostContainer;

        public HttpFactoryHandler(
            IWebHostContainer webHostContainer)
        {
            _webHostContainer = webHostContainer;
        }

        public IInputReceiver Create(MahuaInputConfig config)
        {
            var httpApiConfig = new HttpApiConfig
            {
                Ip = config.Args["host"].ToString(),
                Port = Convert.ToInt32(config.Args["port"])
            };

            var re = new HttpApiInputReceiver(httpApiConfig, _webHostContainer);
            return re;
        }
    }
}