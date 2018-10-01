using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua.CQP.Apis
{
    internal class DeleteMessageApiMahuaCommandHandler : CqpApiMahuaCommandHandlerBase<DeleteMessageApiMahuaCommand, DeleteMessageApiMahuaCommandResult>
    {
        public DeleteMessageApiMahuaCommandHandler(
    ICoolQApi coolQApi,
    ICqpAuthCodeContainer cqpAuthCodeContainer)
    : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override DeleteMessageApiMahuaCommandResult Handle(DeleteMessageApiMahuaCommand message)
        {
            var source = CoolQApi.CQ_deleteMsg(AuthCode, Convert.ToInt64(message.MessageId));
            var re = new DeleteMessageApiMahuaCommandResult
            {
                 IsDeleted = (source == 0)
            };
            return re;
        }
    }
}
