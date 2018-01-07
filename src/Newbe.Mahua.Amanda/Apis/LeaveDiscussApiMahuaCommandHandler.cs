using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class LeaveDiscussApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<LeaveDiscussApiMahuaCommand>
    {
        public LeaveDiscussApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(LeaveDiscussApiMahuaCommand message)
        {
            AmandaApi.Api_QuitDiscussGroup(message.ToDiscuss);
        }
    }
}
