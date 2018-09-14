using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class JoinGroupApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<JoinGroupApiMahuaCommand>
    {
        public JoinGroupApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(JoinGroupApiMahuaCommand message)
        {
            CleverQQApi.Api_JoinGroup(CurrentQq, message.ToGroup, message.Reason);
        }
    }
}
