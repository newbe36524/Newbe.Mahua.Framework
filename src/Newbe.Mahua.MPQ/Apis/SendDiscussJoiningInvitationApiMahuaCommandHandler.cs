using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SendDiscussJoiningInvitationApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SendDiscussJoiningInvitationApiMahuaCommand>
    {
        public SendDiscussJoiningInvitationApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SendDiscussJoiningInvitationApiMahuaCommand message)
        {
            MpqApi.Api_DGInvitation(CurrentQq, message.ToQq, message.ToDiscuss);
        }
    }
}
