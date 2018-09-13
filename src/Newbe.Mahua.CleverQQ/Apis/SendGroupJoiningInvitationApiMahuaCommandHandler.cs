using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class SendGroupJoiningInvitationApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<SendGroupJoiningInvitationApiMahuaCommand>
    {
        public SendGroupJoiningInvitationApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SendGroupJoiningInvitationApiMahuaCommand message)
        {
            CleverQQApi.Api_NoAdminInviteGroup(CurrentQq, message.ToQq, message.ToGroup);
        }
    }
}
