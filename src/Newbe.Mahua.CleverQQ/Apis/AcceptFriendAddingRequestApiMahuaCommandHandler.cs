using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class AcceptFriendAddingRequestApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<AcceptFriendAddingRequestApiMahuaCommand>
    {
        public AcceptFriendAddingRequestApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
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
