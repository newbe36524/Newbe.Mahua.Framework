using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class RemoveBanGroupMemberApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<RemoveBanGroupMemberApiMahuaCommand>
    {
        public RemoveBanGroupMemberApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIR_EventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RemoveBanGroupMemberApiMahuaCommand message)
        {
            CleverQQApi.Api_ShutUP(CurrentQq, message.ToGroup, message.ToQq, 0);
        }
    }
}
