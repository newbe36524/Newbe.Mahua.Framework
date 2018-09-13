using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class AcceptFriendAddingRequestApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<AcceptFriendAddingRequestApiMahuaCommand>
    {
        public AcceptFriendAddingRequestApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIR_EventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(AcceptFriendAddingRequestApiMahuaCommand message)
        {
            // todo addingFriendRequestId
            ResultCode = 1;
        }
    }
}
