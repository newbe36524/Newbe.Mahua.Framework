using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class AcceptGroupJoiningInvitationApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<AcceptGroupJoiningInvitationApiMahuaCommand>
    {
        public AcceptGroupJoiningInvitationApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(AcceptGroupJoiningInvitationApiMahuaCommand message)
        {
            // todo groupJoiningInvitationId
            ResultCode = 1;
        }
    }
}
