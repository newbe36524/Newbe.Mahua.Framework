using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class GetLoginNickApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<GetLoginNickApiMahuaCommand, GetLoginNickApiMahuaCommandResult>
    {
        public GetLoginNickApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetLoginNickApiMahuaCommandResult Handle(GetLoginNickApiMahuaCommand message)
        {
            var nick = MpqApi.Api_GetNick(CurrentQq);
            var re = new GetLoginNickApiMahuaCommandResult
            {
                Nick = nick
            };
            return re;
        }
    }
}
