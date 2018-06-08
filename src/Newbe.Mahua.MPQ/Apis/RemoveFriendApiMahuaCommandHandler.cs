using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class RemoveFriendApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<RemoveFriendApiMahuaCommand>
    {
        public RemoveFriendApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RemoveFriendApiMahuaCommand message)
        {
            MpqApi.Api_DelFriend(CurrentQq, message.ToQq);
        }
    }
}
