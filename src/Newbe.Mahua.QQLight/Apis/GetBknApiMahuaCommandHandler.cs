using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class GetBknApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<GetBknApiMahuaCommand, GetBknApiMahuaCommandResult>
    {
        public GetBknApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override GetBknApiMahuaCommandResult Handle(GetBknApiMahuaCommand message)
        {
            var bkn = QqLightApi.Api_Getbkn();
            var re = new GetBknApiMahuaCommandResult
            {
                Bkn = bkn
            };
            return re;
        }
    }
}
