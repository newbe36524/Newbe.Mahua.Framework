using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class BanGroupMemberApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<BanGroupMemberApiMahuaCommand>
    {
        public BanGroupMemberApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(BanGroupMemberApiMahuaCommand message)
        {
            CleverQQApi.Api_ShutUP(CurrentQq, message.ToGroup, message.ToQq, (int)message.Duration.TotalSeconds);
        }
    }
}
