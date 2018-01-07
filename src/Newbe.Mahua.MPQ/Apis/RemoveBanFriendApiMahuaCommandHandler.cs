using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class RemoveBanFriendApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<RemoveBanFriendApiMahuaCommand>
    {
        public RemoveBanFriendApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override void Handle(RemoveBanFriendApiMahuaCommand message)
        {
            MpqApi.Api_DBan(CurrentQq, message.ToQq);
        }
    }
}
