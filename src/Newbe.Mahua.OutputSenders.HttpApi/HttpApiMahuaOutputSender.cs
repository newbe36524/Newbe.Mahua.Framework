using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Newbe.Mahua.OutputSenders.HttpApi
{
    public class HttpApiOutputSender : IOutputSender
    {
        public delegate HttpApiOutputSender Factory(HttpApiConfig config);

        private readonly HttpApiConfig _config;
        private readonly HttpClient _httpClient;

        public HttpApiOutputSender(
            HttpApiConfig config)
        {
            _config = config;
            _httpClient = new HttpClient();
        }

        public Task Handle(IOutput output)
        {
            return _httpClient.PostAsync(new Uri(_config.Url, UriKind.Absolute),
                new StringContent(JsonConvert.SerializeObject(output),
                    Encoding.UTF8,
                    "application/json"));
        }
    }
}