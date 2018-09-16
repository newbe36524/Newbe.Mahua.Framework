using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class GetGroupsApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<GetGroupsApiMahuaCommand, GetGroupsApiMahuaCommandResult>
    {
        public GetGroupsApiMahuaCommandHandler(
            ICleverQqApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIrEventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetGroupsApiMahuaCommandResult Handle(GetGroupsApiMahuaCommand message)
        {
            var groupsString = CleverQQApi.Api_GetGroupList(CurrentQq);
            var re = new GetGroupsApiMahuaCommandResult
            {
                GroupsString = groupsString
            };
            return re;
        }
    }
}
