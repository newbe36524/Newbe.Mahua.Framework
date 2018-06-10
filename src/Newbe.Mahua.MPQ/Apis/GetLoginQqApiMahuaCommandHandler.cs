using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class GetLoginQqApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<GetLoginQqApiMahuaCommand, GetLoginQqApiMahuaCommandResult>
    {
        public GetLoginQqApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetLoginQqApiMahuaCommandResult Handle(GetLoginQqApiMahuaCommand message)
        {
            var re = new GetLoginQqApiMahuaCommandResult
            {
                Qq = CurrentQq
            };
            return re;
        }
    }
}
