using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class GetGroupMemebersApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<GetGroupMemebersApiMahuaCommand, GetGroupMemebersApiMahuaCommandResult>
    {
        public GetGroupMemebersApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetGroupMemebersApiMahuaCommandResult Handle(GetGroupMemebersApiMahuaCommand message)
        {
            var groupMemebersString = MpqApi.Api_GetGroupMemberA(CurrentQq, message.ToGroup);
            var re = new GetGroupMemebersApiMahuaCommandResult
            {
                GroupMemebersString = groupMemebersString
            };
            return re;
        }
    }
}
