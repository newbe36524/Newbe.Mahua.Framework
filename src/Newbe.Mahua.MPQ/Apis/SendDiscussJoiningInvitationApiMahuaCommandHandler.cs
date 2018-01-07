using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SendDiscussJoiningInvitationApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SendDiscussJoiningInvitationApiMahuaCommand>
    {
        public SendDiscussJoiningInvitationApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override void Handle(SendDiscussJoiningInvitationApiMahuaCommand message)
        {
            MpqApi.Api_DGInvitation(CurrentQq, message.ToQq, message.ToDiscuss);
        }
    }
}
