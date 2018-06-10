using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class CreateDiscussApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<CreateDiscussApiMahuaCommand, CreateDiscussApiMahuaCommandResult>
    {
        public CreateDiscussApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override CreateDiscussApiMahuaCommandResult Handle(CreateDiscussApiMahuaCommand message)
        {
            var discussId = MpqApi.Api_CreateDG(CurrentQq);
            var re = new CreateDiscussApiMahuaCommandResult
            {
                DiscussId = discussId
            };
            return re;
        }
    }
}
