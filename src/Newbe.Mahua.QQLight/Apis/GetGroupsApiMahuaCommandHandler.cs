using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.QQLight.Apis
{
    public class GetGroupsApiMahuaCommandHandler
        : QqLightApiMahuaCommandHandlerBase<GetGroupsApiMahuaCommand, GetGroupsApiMahuaCommandResult>
    {
        public GetGroupsApiMahuaCommandHandler(
            IQqLightApi QqLightApi)
            : base(QqLightApi)
        {
        }

        public override GetGroupsApiMahuaCommandResult Handle(GetGroupsApiMahuaCommand message)
        {
            var groupsString = QqLightApi.Api_GetGroupList();
            var re = new GetGroupsApiMahuaCommandResult
            {
                GroupsString = groupsString
            };
            return re;
        }
    }
}
