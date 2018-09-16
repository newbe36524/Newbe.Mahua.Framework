using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class DissolveGroupApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<DissolveGroupApiMahuaCommand>
    {
        public DissolveGroupApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(DissolveGroupApiMahuaCommand message)
        {
            CleverQQApi.Api_QuitGroup(CurrentQq, message.ToGroup);
        }
    }
}
