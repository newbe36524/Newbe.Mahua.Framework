using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.CQP.Messages.CancelMessage;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SendDiscussMessageApiMahuaCommandHandler : CqpApiMahuaCommandHandlerBase<SendDiscussMessageApiMahuaCommand, SendDiscussMessageApiMahuaCommandResult>
    {
        private readonly CqpMessageCancelToken.Factory _factory;

        public SendDiscussMessageApiMahuaCommandHandler(
            CqpMessageCancelToken.Factory factory,
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
            _factory = factory;
        }

        public override SendDiscussMessageApiMahuaCommandResult Handle(SendDiscussMessageApiMahuaCommand message)
        {
            var source = CoolQApi.CQ_sendDiscussMsg(AuthCode, Convert.ToInt64(message.ToDiscuss), message.Message);
            var re = new SendDiscussMessageApiMahuaCommandResult
            {
                MessageCancelToken = _factory(source),
            };
            return re;
        }
    }
}
