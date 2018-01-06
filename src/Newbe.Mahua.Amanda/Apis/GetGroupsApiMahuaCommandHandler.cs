using Newbe.Mahua.Amanda.NativeApi;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda.Apis
{
    public class GetGroupsApiMahuaCommandHandler
        : AmandaApiMahuaCommandHandlerBase<GetGroupsApiMahuaCommand, GetGroupsApiMahuaCommandResult>
    {
        public GetGroupsApiMahuaCommandHandler(
            IAmandaApi amandaApi)
            : base(amandaApi)
        {
        }

        public override GetGroupsApiMahuaCommandResult Handle(GetGroupsApiMahuaCommand message)
        {
            var groupsString = AmandaApi.Api_GetGroupList();
            var re = new GetGroupsApiMahuaCommandResult
            {
                GroupsString = groupsString
            };
            return re;
        }
    }
}
