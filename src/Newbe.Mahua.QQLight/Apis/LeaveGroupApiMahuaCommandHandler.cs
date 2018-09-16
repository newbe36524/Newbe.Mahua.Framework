using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class LeaveGroupApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<LeaveGroupApiMahuaCommand>
    {
        public LeaveGroupApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(LeaveGroupApiMahuaCommand message)
        {
            QqLightApi.Api_QuitGroup(message.ToGroup);
        }
    }
}
