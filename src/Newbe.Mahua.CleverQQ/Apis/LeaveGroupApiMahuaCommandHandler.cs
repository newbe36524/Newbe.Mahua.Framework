using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class LeaveGroupApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<LeaveGroupApiMahuaCommand>
    {
        public LeaveGroupApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(LeaveGroupApiMahuaCommand message)
        {
            CleverQQApi.Api_QuitGroup(CurrentQq, message.ToGroup);
        }
    }
}
