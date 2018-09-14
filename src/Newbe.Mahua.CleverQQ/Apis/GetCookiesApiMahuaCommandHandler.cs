using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class GetCookiesApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<GetCookiesApiMahuaCommand, GetCookiesApiMahuaCommandResult>
    {
        public GetCookiesApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetCookiesApiMahuaCommandResult Handle(GetCookiesApiMahuaCommand message)
        {
            var cookies = CleverQQApi.Api_GetCookies(CurrentQq);
            var re = new GetCookiesApiMahuaCommandResult
            {
                Cookies = cookies
            };
            return re;
        }
    }
}
