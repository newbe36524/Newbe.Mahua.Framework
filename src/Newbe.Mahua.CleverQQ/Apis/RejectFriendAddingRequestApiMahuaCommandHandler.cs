using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class RejectFriendAddingRequestApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<RejectFriendAddingRequestApiMahuaCommand>
    {
        public RejectFriendAddingRequestApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RejectFriendAddingRequestApiMahuaCommand message)
        {
            // todo addingFriendRequestId
            ResultCode = 2;
        }
    }
}
