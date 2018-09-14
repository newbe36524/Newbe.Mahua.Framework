using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class KickGroupMemberApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<KickGroupMemberApiMahuaCommand>
    {
        public KickGroupMemberApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(KickGroupMemberApiMahuaCommand message)
        {
            // todo notsupport rejectForever
            MpqApi.Api_Kick(CurrentQq, message.ToGroup, message.ToQq);
        }
    }
}
