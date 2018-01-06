using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class KickGroupMemberApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<KickGroupMemberApiMahuaCommand>
    {
        public KickGroupMemberApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override void Handle(KickGroupMemberApiMahuaCommand message)
        {
            // todo notsupport rejectForever
            MpqApi.Api_Kick(CurrentQq, message.ToGroup, message.ToQq);
        }
    }
}
