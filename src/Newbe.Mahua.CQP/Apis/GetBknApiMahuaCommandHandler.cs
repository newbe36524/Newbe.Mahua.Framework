using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class GetBknApiMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<GetBknApiMahuaCommand, GetBknApiMahuaCommandResult>
    {
        public GetBknApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override GetBknApiMahuaCommandResult Handle(GetBknApiMahuaCommand message)
        {
            var cqGetCookies = CoolQApi.CQ_getCsrfToken(AuthCode).ToString();
            return new GetBknApiMahuaCommandResult
            {
                Bkn = cqGetCookies
            };
        }
    }
}
