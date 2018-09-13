using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class RemoveFriendApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<RemoveFriendApiMahuaCommand>
    {
        public RemoveFriendApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIR_EventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RemoveFriendApiMahuaCommand message)
        {
            CleverQQApi.Api_DelFriend(CurrentQq, message.ToQq);
        }
    }
}
