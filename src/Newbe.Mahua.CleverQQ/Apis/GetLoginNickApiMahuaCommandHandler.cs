using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class GetLoginNickApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<GetLoginNickApiMahuaCommand, GetLoginNickApiMahuaCommandResult>
    {
        public GetLoginNickApiMahuaCommandHandler(
            ICleverQqApi cleverQqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverQqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetLoginNickApiMahuaCommandResult Handle(GetLoginNickApiMahuaCommand message)
        {
            var nick = CleverQQApi.Api_GetRInf(CurrentQq);
            var re = new GetLoginNickApiMahuaCommandResult
            {
                Nick = nick
            };
            return re;
        }
    }
}
