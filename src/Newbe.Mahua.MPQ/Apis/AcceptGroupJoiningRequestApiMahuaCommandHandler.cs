using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class AcceptGroupJoiningRequestApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<AcceptGroupJoiningRequestApiMahuaCommand>
    {
        public AcceptGroupJoiningRequestApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(AcceptGroupJoiningRequestApiMahuaCommand message)
        {
            // todo groupJoiningRequestId
            ResultCode = 1;
        }
    }
}
