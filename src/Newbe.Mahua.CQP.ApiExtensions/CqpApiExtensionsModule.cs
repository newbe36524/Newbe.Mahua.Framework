using Autofac;
using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.ApiExtensions.Apis;
using Refit;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;

#pragma warning disable S1075 // URIs should not be hardcoded
namespace Newbe.Mahua.CQP.ApiExtensions
{
    public class CqpApiExtensionsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            if (MahuaGlobal.CurrentPlatform == MahuaPlatform.Cqp)
            {
                builder.RegisterMahuaApi<SetNoticeApiMahuaCommandHandler, SetNoticeApiMahuaCommand>(MahuaGlobal
                    .DefaultApiHandlerAuthorName);
                builder.Register(x =>
                {
                    var api = x.Resolve<IMahuaApi>();
                    var client = new HttpClient(new HttpClientHandler
                    {
                        CookieContainer = GetCookieContainer(api),
                    })
                    {
                        BaseAddress = new Uri("http://web.qun.qq.com/")
                    };
                    client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
                    client.DefaultRequestHeaders.Add("Referer", "http://qun.qq.com/member.html");
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E)");
                    return RestService.For<IQqGroupApi>(client);
                }).As<IQqGroupApi>();
            }
        }

        private static CookieContainer GetCookieContainer(IMahuaApi api)
        {
            var container = new CookieContainer();
            var cookies = api.GetCookies();
            foreach (var s in cookies.Split(';').Select(x => x.Trim()))
            {
                var nameValue = s.Split('=');
                container.Add(new Cookie(nameValue[0], nameValue[1], "/", ".qq.com"));
            }

            return container;
        }
    }
}
#pragma warning restore S1075 // URIs should not be hardcoded
