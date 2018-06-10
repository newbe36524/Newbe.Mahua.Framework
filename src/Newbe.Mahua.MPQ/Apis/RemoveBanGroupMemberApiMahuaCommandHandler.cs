using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class RemoveBanGroupMemberApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<RemoveBanGroupMemberApiMahuaCommand>
    {
        public RemoveBanGroupMemberApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RemoveBanGroupMemberApiMahuaCommand message)
        {
            MpqApi.Api_Shutup(CurrentQq, message.ToGroup, message.ToQq, 0);
        }
    }
}
