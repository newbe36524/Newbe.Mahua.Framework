using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class RemoveBanGroupMemberApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<RemoveBanGroupMemberApiMahuaCommand>
    {
        public RemoveBanGroupMemberApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RemoveBanGroupMemberApiMahuaCommand message)
        {
            CleverQQApi.Api_ShutUP(CurrentQq, message.ToGroup, message.ToQq, 0);
        }
    }
}
