using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class AcceptGroupJoiningRequestApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<AcceptGroupJoiningRequestApiMahuaCommand>
    {
        public AcceptGroupJoiningRequestApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(AcceptGroupJoiningRequestApiMahuaCommand message)
        {
            // todo groupJoiningRequestId
            ResultCode = 1;
        }
    }
}
