using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class RejectGroupJoiningRequestApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<RejectGroupJoiningRequestApiMahuaCommand>
    {
        public RejectGroupJoiningRequestApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RejectGroupJoiningRequestApiMahuaCommand message)
        {
            // todo groupJoiningRequestId
            ResultCode = 2;
        }
    }
}
