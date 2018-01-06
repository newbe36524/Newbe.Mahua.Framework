using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    internal class GetLoginNickApiMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<GetLoginNickApiMahuaCommand, GetLoginNickApiMahuaCommandResult>
    {
        public GetLoginNickApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override GetLoginNickApiMahuaCommandResult Handle(GetLoginNickApiMahuaCommand message)
        {
            var nick = CoolQApi.CQ_getLoginNick(AuthCode);
            return new GetLoginNickApiMahuaCommandResult
            {
                Nick = nick
            };
        }
    }
}
