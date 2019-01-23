using System.Threading.Tasks;
using Newbe.Mahua.Agents.HttpApi.Services;
using Newbe.Mahua.InputReceivers.HttpApi.Services;

namespace Newbe.Mahua.InputReceivers.HttpApi
{
    public class HttpApiInputReceiver : IInputReceiver
    {
        public delegate HttpApiInputReceiver Factory(HttpApiConfig config);

        private readonly HttpApiConfig _config;
        private readonly IWebHostContainer _webHostContainer;

        public HttpApiInputReceiver(
            HttpApiConfig config,
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