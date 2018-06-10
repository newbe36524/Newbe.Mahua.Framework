using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SendGroupJoiningInvitationApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SendGroupJoiningInvitationApiMahuaCommand>
    {
        public SendGroupJoiningInvitationApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SendGroupJoiningInvitationApiMahuaCommand message)
        {
            MpqApi.Api_GroupInvitation(CurrentQq, message.ToQq, message.ToGroup);
        }
    }
}
