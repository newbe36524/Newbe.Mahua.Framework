using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class BanFriendApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<BanFriendApiMahuaCommand>
    {
        public BanFriendApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIR_EventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(BanFriendApiMahuaCommand message)
        {
            CleverQQApi.Api_AddBkList(CurrentQq, message.ToQq);
        }
    }
}
