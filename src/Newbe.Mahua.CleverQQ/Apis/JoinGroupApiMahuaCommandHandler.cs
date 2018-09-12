using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class JoinGroupApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<JoinGroupApiMahuaCommand>
    {
        public JoinGroupApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIR_EventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(JoinGroupApiMahuaCommand message)
        {
            CleverQQApi.Api_JoinGroup(CurrentQq, message.ToGroup, message.Reason);
        }
    }
}
