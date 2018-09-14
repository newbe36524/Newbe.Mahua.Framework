using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class RemoveFriendApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<RemoveFriendApiMahuaCommand>
    {
        public RemoveFriendApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RemoveFriendApiMahuaCommand message)
        {
            CleverQQApi.Api_DelFriend(CurrentQq, message.ToQq);
        }
    }
}
