using Newbe.Mahua.Logging;
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

        // TODO 需要测试
        public Func<string> DefaultQqProvider => () =>
        {
            var apiGetOnlineQQlist = _mpqApi.Api_GetOnlineQQlist();
            LogProvider.For<QqProvider>().Info($" get qq list {apiGetOnlineQQlist}");
            return string.Empty;
        };

        public bool CheckQq(string qq)
        {
            // TODO 需要实现
            return false;
        }
    }
}
