using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class RejectFriendAddingRequestApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<RejectFriendAddingRequestApiMahuaCommand>
    {
        public RejectFriendAddingRequestApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RejectFriendAddingRequestApiMahuaCommand message)
        {
            // todo addingFriendRequestId
            ResultCode = 2;
        }
    }
}
