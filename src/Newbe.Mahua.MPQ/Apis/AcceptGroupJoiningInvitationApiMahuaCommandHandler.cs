using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class AcceptGroupJoiningInvitationApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<AcceptGroupJoiningInvitationApiMahuaCommand>
    {
        public AcceptGroupJoiningInvitationApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(AcceptGroupJoiningInvitationApiMahuaCommand message)
        {
            // todo groupJoiningInvitationId
            ResultCode = 1;
        }
    }
}
