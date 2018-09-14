using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class RejectGroupJoiningInvitationApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<RejectGroupJoiningInvitationApiMahuaCommand>
    {
        public RejectGroupJoiningInvitationApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RejectGroupJoiningInvitationApiMahuaCommand message)
        {
            // todo groupJoiningInvitationId
            ResultCode = 2;
        }
    }
}
