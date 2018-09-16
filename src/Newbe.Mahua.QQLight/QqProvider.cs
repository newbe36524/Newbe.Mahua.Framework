using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight
{
    public class QqProvider : IQqProvider
    {
        private readonly IQqLightApi _QqLightApi;

        public QqProvider(
            IQqLightApi QqLightApi)
        {
            _QqLightApi = QqLightApi;
        }

        public Func<string> DefaultQqProvider => () => _QqLightApi.Api_GetLoginQQ();

        public bool CheckQq(string qq)
        {
            return DefaultQqProvider() == qq;
        }
    }
}
