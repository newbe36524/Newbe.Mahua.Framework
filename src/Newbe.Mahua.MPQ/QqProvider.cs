using Newbe.Mahua.MPQ.NativeApi;
using System;

namespace Newbe.Mahua.MPQ
{
    public class QqProvider : IQqProvider
    {
        private readonly IMpqApi _mpqApi;

        public QqProvider(
            IMpqApi mpqApi)
        {
            _mpqApi = mpqApi;
        }

        public Func<string> DefaultQqProvider => () =>
        {
            var apiGetOnlineQQlist = _mpqApi.Api_GetOnlineQQlist();
            return apiGetOnlineQQlist;
        };

        public bool CheckQq(string qq)
        {
            return DefaultQqProvider() == qq;
        }
    }
}
