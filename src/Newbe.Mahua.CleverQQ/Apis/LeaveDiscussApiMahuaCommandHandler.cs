using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class LeaveDiscussApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<LeaveDiscussApiMahuaCommand>
    {
        public LeaveDiscussApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIR_EventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(LeaveDiscussApiMahuaCommand message)
        {
            CleverQQApi.Api_QuitDisGroup(CurrentQq, message.ToDiscuss);
        }
    }
}
