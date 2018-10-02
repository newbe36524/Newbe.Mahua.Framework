using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class GetLoginQqApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<GetLoginQqApiMahuaCommand, GetLoginQqApiMahuaCommandResult>
    {
        public GetLoginQqApiMahuaCommandHandler(
            ICleverQqApi cleverQqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverQqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetLoginQqApiMahuaCommandResult Handle(GetLoginQqApiMahuaCommand message)
        {
            var re = new GetLoginQqApiMahuaCommandResult
            {
                Qq = CurrentQq
            };
            return re;
        }
    }
}
