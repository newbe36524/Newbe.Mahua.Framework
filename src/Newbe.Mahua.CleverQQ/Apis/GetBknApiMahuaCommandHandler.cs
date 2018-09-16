using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class GetBknApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<GetBknApiMahuaCommand, GetBknApiMahuaCommandResult>
    {
        public GetBknApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetBknApiMahuaCommandResult Handle(GetBknApiMahuaCommand message)
        {
            var bkn = CleverQQApi.Api_GetBkn32(CurrentQq);
            var re = new GetBknApiMahuaCommandResult
            {
                Bkn = bkn
            };
            return re;
        }
    }
}
