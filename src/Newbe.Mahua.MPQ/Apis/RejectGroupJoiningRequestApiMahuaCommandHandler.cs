using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class RejectGroupJoiningRequestApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<RejectGroupJoiningRequestApiMahuaCommand>
    {
        public RejectGroupJoiningRequestApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(RejectGroupJoiningRequestApiMahuaCommand message)
        {
            // todo groupJoiningRequestId
            ResultCode = 2;
        }
    }
}
