using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ
{
    public class QqProvider : IQqProvider
    {
        private readonly ICleverQqApi _cleverqqApi;

        public QqProvider(
            ICleverQqApi cleverqqApi)
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
