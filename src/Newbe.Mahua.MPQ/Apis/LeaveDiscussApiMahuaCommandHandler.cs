using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class LeaveDiscussApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<LeaveDiscussApiMahuaCommand>
    {
        public LeaveDiscussApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(LeaveDiscussApiMahuaCommand message)
        {
            MpqApi.Api_QuitDG(CurrentQq, message.ToDiscuss);
        }
    }
}
