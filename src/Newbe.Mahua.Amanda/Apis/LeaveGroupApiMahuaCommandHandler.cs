using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class LeaveGroupApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<LeaveGroupApiMahuaCommand>
    {
        public LeaveGroupApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override void Handle(LeaveGroupApiMahuaCommand message)
        {
            AmandaApi.Api_QuitGroup(message.ToGroup);
        }
    }
}
