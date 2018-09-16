using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class SetGroupMemberCardApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<SetGroupMemberCardApiMahuaCommand>
    {
        public SetGroupMemberCardApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(SetGroupMemberCardApiMahuaCommand message)
        {
            QqLightApi.Api_SetGroupCard(message.ToGroup, message.ToQq, message.GroupMemberCard);
        }
    }
}
