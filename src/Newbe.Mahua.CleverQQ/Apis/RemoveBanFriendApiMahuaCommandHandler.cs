using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class RemoveBanFriendApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<RemoveBanFriendApiMahuaCommand>
    {
        public RemoveBanFriendApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIR_EventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RemoveBanFriendApiMahuaCommand message)
        {
            CleverQQApi.Api_AddBkList(CurrentQq, message.ToQq);
        }
    }
}
