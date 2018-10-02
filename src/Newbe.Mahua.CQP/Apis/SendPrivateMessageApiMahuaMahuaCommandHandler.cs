using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.CQP.Messages.CancelMessage;
using Newbe.Mahua.Messages;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SendPrivateMessageApiMahuaMahuaCommandHandler : CqpApiMahuaCommandHandlerBase<SendPrivateMessageApiMahuaCommand, SendPrivateMessageApiMahuaCommandResult>
    {
        private readonly CqpMessageCancelToken.Factory _factory;

        public SendPrivateMessageApiMahuaMahuaCommandHandler(
            CqpMessageCancelToken.Factory factory,
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
            _factory = factory;
        }

        public override SendPrivateMessageApiMahuaCommandResult Handle(SendPrivateMessageApiMahuaCommand message)
        {
            var source = CoolQApi.CQ_sendPrivateMsg(AuthCode, Convert.ToInt64(message.ToQq), message.Message);
            var re = new SendPrivateMessageApiMahuaCommandResult
            {
                MessageCancelToken = _factory(source),
            };
            return re;
        }
    }
}
