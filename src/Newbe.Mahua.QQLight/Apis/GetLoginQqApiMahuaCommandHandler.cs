using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class GetLoginQqApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<GetLoginQqApiMahuaCommand, GetLoginQqApiMahuaCommandResult>
    {
        public GetLoginQqApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override GetLoginQqApiMahuaCommandResult Handle(GetLoginQqApiMahuaCommand message)
        {
            var qq = QqLightApi.Api_GetLoginQQ();
            var re = new GetLoginQqApiMahuaCommandResult
            {
                Qq = qq
            };
            return re;
        }
    }
}
