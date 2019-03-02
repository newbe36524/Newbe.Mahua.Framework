using System;
using Newbe.Mahua.InputReceivers.WebsocketApi.Services;

namespace Newbe.Mahua.InputReceivers.WebsocketApi
{
    public class InputReceiverFactoryHandler : IInputReceiverFactoryHandler
    {
        private readonly IWebHostContainer _webHostContainer;

        public InputReceiverFactoryHandler(
            IWebHostContainer webHostContainer)
        {
            _webHostContainer = webHostContainer;
        }

        public IInputReceiver Create(MahuaInputConfig config)
        {
            var websocketApiConfig = new WebsocketApiConfig
            {
                Ip = config.Args["host"].ToString(),
                Port = Convert.ToInt32(config.Args["port"]),
            };

            var re = new WebsocketInputReceiver(websocketApiConfig, _webHostContainer);
            return re;
        }
    }
}