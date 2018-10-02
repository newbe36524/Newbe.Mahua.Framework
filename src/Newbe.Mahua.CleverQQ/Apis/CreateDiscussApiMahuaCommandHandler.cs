using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class CreateDiscussApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<CreateDiscussApiMahuaCommand, CreateDiscussApiMahuaCommandResult>
    {
        public CreateDiscussApiMahuaCommandHandler(
            ICleverQqApi cleverQqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverQqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override CreateDiscussApiMahuaCommandResult Handle(CreateDiscussApiMahuaCommand message)
        {
            var discussId = CleverQQApi.Api_CreateDisGroup(CurrentQq, "讨论组");
            var re = new CreateDiscussApiMahuaCommandResult
            {
                DiscussId = discussId
            };
            return re;
        }
    }
}
