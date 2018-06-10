using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SetGroupMemberCardApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SetGroupMemberCardApiMahuaCommand>
    {
        public SetGroupMemberCardApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SetGroupMemberCardApiMahuaCommand message)
        {
            MpqApi.Api_SetNameCard(CurrentQq, message.ToGroup, message.ToQq, message.GroupMemberCard);
        }
    }
}
