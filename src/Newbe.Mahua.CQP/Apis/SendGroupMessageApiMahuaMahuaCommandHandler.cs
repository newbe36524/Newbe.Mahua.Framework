using Newbe.Mahua.Apis;
using System;
using Newbe.Mahua.CQP.Messages.CancelMessage;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class SendGroupMessageApiMahuaMahuaCommandHandler : CqpApiMahuaCommandHandlerBase<SendGroupMessageApiMahuaCommand, SendGroupMessageApiMahuaCommandResult>
    {
        private readonly CqpMessageCancelToken.Factory _factory;

        public SendGroupMessageApiMahuaMahuaCommandHandler(
            CqpMessageCancelToken.Factory factory,
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
            _factory = factory;
        }

        public override SendGroupMessageApiMahuaCommandResult Handle(SendGroupMessageApiMahuaCommand message)
        {
            var source = CoolQApi.CQ_sendGroupMsg(AuthCode, Convert.ToInt64(message.ToGroup), message.Message);
            var re = new SendGroupMessageApiMahuaCommandResult
            {
                MessageCancelToken = _factory(source)
            };
            return re;
        }
    }
}
