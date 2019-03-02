using System.Threading.Tasks;
using Newbe.Mahua.InputReceivers.WebsocketApi.Services;

namespace Newbe.Mahua.InputReceivers.WebsocketApi
{
    public class WebsocketInputReceiver : IInputReceiver
    {
        public delegate WebsocketInputReceiver Factory(WebsocketApiConfig config);

        private readonly WebsocketApiConfig _config;
        private readonly IWebHostContainer _webHostContainer;

        public WebsocketInputReceiver(
            WebsocketApiConfig config,
            IWebHostContainer webHostContainer)
        {
            _config = config;
            _webHostContainer = webHostContainer;
        }

        public Task Start()
        {
            return _webHostContainer.CreateInstance(_config).StartAsync();
        }
    }
}