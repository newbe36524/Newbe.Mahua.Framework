using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class LeaveGroupApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<LeaveGroupApiMahuaCommand>
    {
        public LeaveGroupApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(LeaveGroupApiMahuaCommand message)
        {
            MpqApi.Api_QuitGroup(CurrentQq, message.ToGroup);
        }
    }
}
