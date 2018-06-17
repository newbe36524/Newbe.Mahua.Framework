using Newbe.Mahua.Samples.OkexRobot.Common;
using Refit;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Newbe.Mahua.Samples.OkexRobot.OkexApi
{
    public interface IOkexApiFactory
    {
        T Create<T>() where T : IOkexApi;
    }

    public class OkexOkexApiFactory : IOkexApiFactory
    {
        private static readonly Lazy<HttpClient> Client = new Lazy<HttpClient>(() => new HttpClient(new MyClient
        {
            UseProxy = true,
            Proxy = new WebProxy
            {
                Address = new Uri(SystemOptions.Instance.HttpProxyUri),
                UseDefaultCredentials = false,
            }
        })
        {
            BaseAddress = new Uri("https://www.okex.com/api")
        });
        public T Create<T>() where T : IOkexApi
        {
            var api = RestService.For<T>(Client.Value, new RefitSettings
            {
            });
            return api;
        }

        class MyClient : HttpClientHandler
        {
            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                if (request.Content != null)
                {
                    var content = await request.Content.ReadAsStringAsync();
                }
                var responce = await base.SendAsync(request, cancellationToken);
                if (responce.Content != null)
                {
                    var respContent = await responce.Content.ReadAsStringAsync();
                }
                return responce;
            }
        }
    }
}
