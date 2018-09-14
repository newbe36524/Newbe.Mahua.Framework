using Newbe.Mahua.Apis;
using Newbe.Mahua.QQLight.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class LeaveDiscussApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<LeaveDiscussApiMahuaCommand>
    {
        public LeaveDiscussApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override void Handle(LeaveDiscussApiMahuaCommand message)
        {
            QqLightApi.Api_QuitDiscussGroup(message.ToDiscuss);
        }
    }
}
