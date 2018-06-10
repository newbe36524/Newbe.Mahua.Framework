using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class BanGroupMemberApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<BanGroupMemberApiMahuaCommand>
    {
        public BanGroupMemberApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(BanGroupMemberApiMahuaCommand message)
        {
            MpqApi.Api_Shutup(CurrentQq, message.ToGroup, message.ToQq, (int)message.Duration.TotalSeconds);
        }
    }
}
