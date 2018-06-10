using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class DissolveGroupApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<DissolveGroupApiMahuaCommand>
    {
        public DissolveGroupApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override void Handle(DissolveGroupApiMahuaCommand message)
        {
            MpqApi.Api_QuitGroup(CurrentQq, message.ToGroup);
        }
    }
}
