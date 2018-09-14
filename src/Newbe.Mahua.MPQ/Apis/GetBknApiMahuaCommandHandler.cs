using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class GetBknApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<GetBknApiMahuaCommand, GetBknApiMahuaCommandResult>
    {
        public GetBknApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetBknApiMahuaCommandResult Handle(GetBknApiMahuaCommand message)
        {
            var bkn = MpqApi.Api_GetBkn32(CurrentQq);
            var re = new GetBknApiMahuaCommandResult
            {
                Bkn = bkn
            };
            return re;
        }
    }
}
