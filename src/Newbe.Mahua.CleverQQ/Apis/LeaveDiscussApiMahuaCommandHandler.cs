using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class LeaveDiscussApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<LeaveDiscussApiMahuaCommand>
    {
        public LeaveDiscussApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(LeaveDiscussApiMahuaCommand message)
        {
            CleverQQApi.Api_QuitDisGroup(CurrentQq, message.ToDiscuss);
        }
    }
}
