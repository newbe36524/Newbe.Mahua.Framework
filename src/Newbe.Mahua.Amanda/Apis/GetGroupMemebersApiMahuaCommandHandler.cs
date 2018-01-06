using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class GetGroupMemebersApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<GetGroupMemebersApiMahuaCommand, GetGroupMemebersApiMahuaCommandResult>
    {
        public GetGroupMemebersApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override GetGroupMemebersApiMahuaCommandResult Handle(GetGroupMemebersApiMahuaCommand message)
        {
            var groupMemebersString = AmandaApi.Api_GetGroupMemberList(message.ToGroup);
            var re = new GetGroupMemebersApiMahuaCommandResult
            {
                GroupMemebersString = groupMemebersString
            };
            return re;
        }
    }
}
