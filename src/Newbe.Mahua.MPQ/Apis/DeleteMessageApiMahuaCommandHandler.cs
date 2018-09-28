using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua.MPQ.Apis
{
    public class DeleteMessageApiMahuaCommandHandler : MpqApiMahuaCommandHandlerBase<DeleteMessageApiMahuaCommand, DeleteMessageApiMahuaCommandResult>
    {
        public DeleteMessageApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override DeleteMessageApiMahuaCommandResult Handle(DeleteMessageApiMahuaCommand message)
        {
            var re = new DeleteMessageApiMahuaCommandResult
            {
                IsDeleted = false
            };
            return re;
        }
    }
}
