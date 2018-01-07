using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class BanFriendApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<BanFriendApiMahuaCommand>
    {
        public BanFriendApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override void Handle(BanFriendApiMahuaCommand message)
        {
            MpqApi.Api_Ban(CurrentQq, message.ToQq);
        }
    }
}
