using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class SetGroupMemberCardApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<SetGroupMemberCardApiMahuaCommand>
    {
        public SetGroupMemberCardApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(SetGroupMemberCardApiMahuaCommand message)
        {
            AmandaApi.Api_SetGroupCard(message.ToGroup, message.ToQq, message.GroupMemberCard);
        }
    }
}
