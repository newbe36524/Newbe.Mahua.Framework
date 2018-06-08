using Newbe.Mahua.Amanda.NativeApi;
using System;

namespace Newbe.Mahua.Amanda
{
    public class QqProvider : IQqProvider
    {
        private readonly IAmandaApi _amandaApi;

        public QqProvider(
            IAmandaApi amandaApi)
        {
            _amandaApi = amandaApi;
        }

        public Func<string> DefaultQqProvider => () => _amandaApi.Api_GetLoginQQ();

        public bool CheckQq(string qq)
        {
            return DefaultQqProvider() == qq;
        }
    }
}
