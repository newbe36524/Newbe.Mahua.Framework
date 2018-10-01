using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class DeleteMessageApiMahuaCommandHandler
    : CleverQQApiMahuaCommandHandlerBase<DeleteMessageApiMahuaCommand, DeleteMessageApiMahuaCommandResult>
    {
        public DeleteMessageApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override DeleteMessageApiMahuaCommandResult Handle(DeleteMessageApiMahuaCommand message)
        {
            var source = CleverQQApi.Api_WithdrawMsg(CurrentQq, message.TargetId, message.Type, message.MessageId);
            var re = new DeleteMessageApiMahuaCommandResult
            {
                IsDeleted = source
            };
            return re;
        }
    }
}
