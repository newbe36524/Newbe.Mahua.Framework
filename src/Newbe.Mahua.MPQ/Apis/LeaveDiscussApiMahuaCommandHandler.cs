using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class LeaveDiscussApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<LeaveDiscussApiMahuaCommand>
    {
        public LeaveDiscussApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override void Handle(LeaveDiscussApiMahuaCommand message)
        {
            MpqApi.Api_QuitDG(CurrentQq, message.ToDiscuss);
        }
    }
}
