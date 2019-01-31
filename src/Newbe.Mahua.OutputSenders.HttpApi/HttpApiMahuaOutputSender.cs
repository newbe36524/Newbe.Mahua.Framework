using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
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
            _httpClient = new HttpClient
            {
                Timeout = config.Timeout,
            };
        }

        public Task Handle(IOutput output)
        {
            return Task.WhenAll(MultipleHandle());

            IEnumerable<Task> MultipleHandle()
            {
                if (!string.IsNullOrEmpty(_config.Url))
                {
                    yield return SendRequest(_config.Url);
                }

                if (_config.Urls != null)
                {
                    foreach (var configUrl in _config.Urls)
                    {
                        yield return SendRequest(configUrl);
                    }
                }
            }

            Task SendRequest(string url)
            {
                return _httpClient.PostAsync(new Uri(url, UriKind.Absolute),
                    new StringContent(JsonConvert.SerializeObject(output),
                        Encoding.UTF8,
                        "application/json"));
            }
        }
    }
}