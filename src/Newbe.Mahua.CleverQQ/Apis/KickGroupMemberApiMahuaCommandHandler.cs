using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class KickGroupMemberApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<KickGroupMemberApiMahuaCommand>
    {
        public KickGroupMemberApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(KickGroupMemberApiMahuaCommand message)
        {
            // todo notsupport rejectForever
            CleverQQApi.Api_KickGroupMBR(CurrentQq, message.ToGroup, message.ToQq, false);
        }
    }
}
