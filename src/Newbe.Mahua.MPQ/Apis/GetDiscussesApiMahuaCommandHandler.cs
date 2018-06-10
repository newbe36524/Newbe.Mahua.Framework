using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class GetDiscussesApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<GetDiscussesApiMahuaCommand, GetDiscussesApiMahuaCommandResult>
    {
        public GetDiscussesApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetDiscussesApiMahuaCommandResult Handle(GetDiscussesApiMahuaCommand message)
        {
            var discussesString = MpqApi.Api_GetDGList(CurrentQq);
            var re = new GetDiscussesApiMahuaCommandResult
            {
                DiscussesString = discussesString
            };
            return re;
        }
    }
}
