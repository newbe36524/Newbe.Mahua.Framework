using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class KickDiscussMemberApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<KickDiscussMemberApiMahuaCommand>
    {
        public KickDiscussMemberApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(KickDiscussMemberApiMahuaCommand message)
        {
            CleverQQApi.Api_KickDisGroupMBR(CurrentQq, message.ToQq, message.ToDiscuss);
        }
    }
}
