using Newbe.Mahua.CleverQQ.NativeApi;
using System;

namespace Newbe.Mahua.CleverQQ
{
    public class QqProvider : IQqProvider
    {
        private readonly ICleverQQApi _cleverqqApi;

        public QqProvider(
            ICleverQQApi cleverqqApi)
        {
            _cleverqqApi = cleverqqApi;
        }

        public Func<string> DefaultQqProvider => () =>
        {
            var apiGetOnlineQQlist = _cleverqqApi.Api_GetOnLineList();
            return apiGetOnlineQQlist;
        };

        public bool CheckQq(string qq)
        {
            return DefaultQqProvider() == qq;
        }
    }
}
