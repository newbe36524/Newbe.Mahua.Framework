using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class GetGroupMemebersApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<GetGroupMemebersApiMahuaCommand, GetGroupMemebersApiMahuaCommandResult>
    {
        public GetGroupMemebersApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
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
