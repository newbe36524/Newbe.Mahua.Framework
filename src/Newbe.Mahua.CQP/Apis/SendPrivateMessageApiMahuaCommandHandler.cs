using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    public class SendPrivateMessageApiMahuaCommandHandler : IApiCommandHandler<SendPrivateMessageApiMahuaCommand>
    {
        private readonly ICqpAuthCodeContainer _authCodeContainer;
        private readonly ICoolQApi _coolQApi;

        public SendPrivateMessageApiMahuaCommandHandler(
            ICqpAuthCodeContainer authCodeContainer,
            ICoolQApi coolQApi)
        {
            _authCodeContainer = authCodeContainer;
            _coolQApi = coolQApi;
        }

        public void Handle(SendPrivateMessageApiMahuaCommand message)
        {
            _coolQApi.CQ_sendPrivateMsg(_authCodeContainer.AuthCode, Convert.ToInt64(message.ToQq), message.Message);
        }
    }
}
