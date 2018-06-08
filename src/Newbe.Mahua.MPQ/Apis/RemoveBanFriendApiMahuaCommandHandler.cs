using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class RemoveBanFriendApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<RemoveBanFriendApiMahuaCommand>
    {
        public RemoveBanFriendApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RemoveBanFriendApiMahuaCommand message)
        {
            MpqApi.Api_DBan(CurrentQq, message.ToQq);
        }
    }
}
