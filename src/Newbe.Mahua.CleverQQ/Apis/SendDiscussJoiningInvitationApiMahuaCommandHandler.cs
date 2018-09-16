using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class SendDiscussJoiningInvitationApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<SendDiscussJoiningInvitationApiMahuaCommand>
    {
        public SendDiscussJoiningInvitationApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SendDiscussJoiningInvitationApiMahuaCommand message)
        {
            CleverQQApi.Api_InviteDisGroup(CurrentQq, message.ToDiscuss, message.ToQq);
        }
    }
}
