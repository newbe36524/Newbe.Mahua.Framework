using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class GetBknApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<GetBknApiMahuaCommand, GetBknApiMahuaCommandResult>
    {
        public GetBknApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override GetBknApiMahuaCommandResult Handle(GetBknApiMahuaCommand message)
        {
            var bkn = AmandaApi.Api_Getbkn();
            var re = new GetBknApiMahuaCommandResult
            {
                Bkn = bkn
            };
            return re;
        }
    }
}
