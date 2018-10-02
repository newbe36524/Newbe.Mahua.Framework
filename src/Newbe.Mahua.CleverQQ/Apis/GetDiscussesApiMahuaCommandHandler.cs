using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class GetDiscussesApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<GetDiscussesApiMahuaCommand, GetDiscussesApiMahuaCommandResult>
    {
        public GetDiscussesApiMahuaCommandHandler(
            ICleverQqApi cleverQqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverQqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetDiscussesApiMahuaCommandResult Handle(GetDiscussesApiMahuaCommand message)
        {
            var discussesString = CleverQQApi.Api_GetDisGroupList(CurrentQq);
            var re = new GetDiscussesApiMahuaCommandResult
            {
                DiscussesString = discussesString
            };
            return re;
        }
    }
}
