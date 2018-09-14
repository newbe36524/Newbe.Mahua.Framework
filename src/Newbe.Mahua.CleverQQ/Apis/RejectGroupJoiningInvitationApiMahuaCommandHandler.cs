using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class RejectGroupJoiningInvitationApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<RejectGroupJoiningInvitationApiMahuaCommand>
    {
        public RejectGroupJoiningInvitationApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RejectGroupJoiningInvitationApiMahuaCommand message)
        {
            // todo groupJoiningInvitationId
            ResultCode = 2;
        }
    }
}
