using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua.QQLight.Apis
{
    public class DeleteMessageApiMahuaCommandHandler : QqLightApiMahuaCommandHandlerBase<DeleteMessageApiMahuaCommand, DeleteMessageApiMahuaCommandResult>
    {
        public DeleteMessageApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override DeleteMessageApiMahuaCommandResult Handle(DeleteMessageApiMahuaCommand message)
        {
            QqLightApi.Api_DeleteMsg(message.TargetId,message.MessageId.ToString());
            var re = new DeleteMessageApiMahuaCommandResult
            {
                IsDeleted = true
            };
            return re;
        }
    }
}
