using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class SetGroupMemberCardApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<SetGroupMemberCardApiMahuaCommand>
    {
        public SetGroupMemberCardApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(SetGroupMemberCardApiMahuaCommand message)
        {
            CleverQQApi.Api_SetGroupCard(CurrentQq, message.ToGroup, message.ToQq, message.GroupMemberCard);
        }
    }
}
