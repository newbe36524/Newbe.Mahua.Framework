using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class BanFriendApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<BanFriendApiMahuaCommand>
    {
        public BanFriendApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(BanFriendApiMahuaCommand message)
        {
            CleverQQApi.Api_AddBkList(CurrentQq, message.ToQq);
        }
    }
}
