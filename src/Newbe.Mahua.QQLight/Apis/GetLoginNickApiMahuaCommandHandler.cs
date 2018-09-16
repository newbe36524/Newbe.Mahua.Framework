using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class GetLoginNickApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<GetLoginNickApiMahuaCommand, GetLoginNickApiMahuaCommandResult>
    {
        public GetLoginNickApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override GetLoginNickApiMahuaCommandResult Handle(GetLoginNickApiMahuaCommand message)
        {
            var nick = QqLightApi.Api_GetNick(QqLightApi.Api_GetLoginQQ());
            var re = new GetLoginNickApiMahuaCommandResult
            {
                Nick = nick
            };
            return re;
        }
    }
}
