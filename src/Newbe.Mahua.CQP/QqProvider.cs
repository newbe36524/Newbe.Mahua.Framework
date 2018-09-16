using System;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP
{
    public class QqProvider : IQqProvider
    {
        private readonly ICoolQApi _coolQApi;
        private readonly ICqpAuthCodeContainer _authCodeContainer;

        public QqProvider(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer authCodeContainer)
        {
            _coolQApi = coolQApi;
            _authCodeContainer = authCodeContainer;
        }

        public Func<string> DefaultQqProvider => () => _coolQApi.CQ_getLoginQQ(_authCodeContainer.AuthCode).ToString();

        public bool CheckQq(string qq)
        {
            return qq == DefaultQqProvider();
        }
    }
}
