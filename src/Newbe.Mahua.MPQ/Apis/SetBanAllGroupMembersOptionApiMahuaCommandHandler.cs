using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SetBanAllGroupMembersOptionApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SetBanAllGroupMembersOptionApiMahuaCommand>
    {
        public SetBanAllGroupMembersOptionApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SetBanAllGroupMembersOptionApiMahuaCommand message)
        {
            MpqApi.Api_Shutup(CurrentQq, message.ToGroup, null, 0);
        }
    }
}
