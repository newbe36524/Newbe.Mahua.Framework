using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class GetCookiesApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<GetCookiesApiMahuaCommand, GetCookiesApiMahuaCommandResult>
    {
        public GetCookiesApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetCookiesApiMahuaCommandResult Handle(GetCookiesApiMahuaCommand message)
        {
            var cookies = MpqApi.Api_GetCookies(CurrentQq);
            var re = new GetCookiesApiMahuaCommandResult
            {
                Cookies = cookies
            };
            return re;
        }
    }
}
