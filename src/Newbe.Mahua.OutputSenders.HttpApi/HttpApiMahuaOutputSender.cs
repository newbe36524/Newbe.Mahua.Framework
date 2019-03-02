using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newbe.Mahua.Logging;
using Newtonsoft.Json;

namespace Newbe.Mahua.OutputSenders.HttpApi
{
    public class HttpApiOutputSender : IOutputSender
    {
        public delegate HttpApiOutputSender Factory(HttpApiConfig config);

        private static readonly ILog Logger = LogProvider.For<HttpApiOutputSender>();

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

            async Task SendRequest(string url)
            {
                try
                {
                    await _httpClient.PostAsync(new Uri(url, UriKind.Absolute),
                        new StringContent(JsonConvert.SerializeObject(output),
                            Encoding.UTF8,
                            "application/json"));
                }
                catch (Exception e)
                {
                    // ignore all exception when sending error
                    Logger.WarnException("throw a exception when sending output by http. this may cause by error http config or remote server error. please check configuration.", e);
                }
            }
        }
    }
}