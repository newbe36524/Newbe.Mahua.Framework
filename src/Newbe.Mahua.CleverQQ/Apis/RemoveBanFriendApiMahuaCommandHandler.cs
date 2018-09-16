using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class RemoveBanFriendApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<RemoveBanFriendApiMahuaCommand>
    {
        public RemoveBanFriendApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RemoveBanFriendApiMahuaCommand message)
        {
            CleverQQApi.Api_AddBkList(CurrentQq, message.ToQq);
        }
    }
}
