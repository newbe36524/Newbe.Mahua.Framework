using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SetGroupMemberCardApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SetGroupMemberCardApiMahuaCommand>
    {
        public SetGroupMemberCardApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override void Handle(SetGroupMemberCardApiMahuaCommand message)
        {
            MpqApi.Api_SetNameCard(CurrentQq, message.ToGroup, message.ToQq, message.GroupMemberCard);
        }
    }
}
