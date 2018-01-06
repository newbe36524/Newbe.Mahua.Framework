using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class GetLoginQqApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<GetLoginQqApiMahuaCommand, GetLoginQqApiMahuaCommandResult>
    {
        public GetLoginQqApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override GetLoginQqApiMahuaCommandResult Handle(GetLoginQqApiMahuaCommand message)
        {
            var qq = AmandaApi.Api_GetLoginQQ();
            var re = new GetLoginQqApiMahuaCommandResult
            {
                Qq = qq
            };
            return re;
        }
    }
}
