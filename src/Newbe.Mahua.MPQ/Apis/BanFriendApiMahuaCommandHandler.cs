using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class BanFriendApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<BanFriendApiMahuaCommand>
    {
        public BanFriendApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(BanFriendApiMahuaCommand message)
        {
            MpqApi.Api_Ban(CurrentQq, message.ToQq);
        }
    }
}
